using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Formula_1_Projekt
{
    //NEMMM MI ÍRTUK EZT SEGÍTSÉGÜL VETTÜK AZ INTERNET NÉPÉTŐL EZÉRT NEM TUDJUK SUMMARYZNI ÉS NINCS A DOKSIBAN!!!!
    public class SortableBindingList<T> : BindingList<T>
    {
        private bool _isSorted;
        private ListSortDirection _sortDirection;
        private PropertyDescriptor _sortProperty;

        public SortableBindingList() : base() { }

        public SortableBindingList(IList<T> list) : base(list) { }

        protected override bool SupportsSortingCore => true;
        protected override bool IsSortedCore => _isSorted;
        protected override ListSortDirection SortDirectionCore => _sortDirection;
        protected override PropertyDescriptor SortPropertyCore => _sortProperty;

        protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
        {
            _sortProperty = prop;
            _sortDirection = direction;

            if (Items is List<T> list)
            {
                var comparer = new PropertyComparer<T>(prop, direction);
                list.Sort(comparer);
            }

            _isSorted = true;
            OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
        }

        protected override void RemoveSortCore()
        {
            _isSorted = false;
            _sortDirection = ListSortDirection.Ascending;
            _sortProperty = null;
        }
    }

    public class PropertyComparer<T> : IComparer<T>
    {
        private readonly PropertyDescriptor _property;
        private readonly ListSortDirection _direction;

        public PropertyComparer(PropertyDescriptor property, ListSortDirection direction)
        {
            _property = property;
            _direction = direction;
        }

        public int Compare(T x, T y)
        {
            var valueX = _property.GetValue(x) as IComparable;
            var valueY = _property.GetValue(y) as IComparable;

            if (_direction == ListSortDirection.Ascending)
            {
                return valueX?.CompareTo(valueY) ?? 0;
            }
            else
            {
                return valueY?.CompareTo(valueX) ?? 0;
            }
        }
    }
}
