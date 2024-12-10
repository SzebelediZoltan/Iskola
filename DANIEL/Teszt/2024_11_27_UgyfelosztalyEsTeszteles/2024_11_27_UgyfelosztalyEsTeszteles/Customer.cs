using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_27_UgyfelosztalyEsTeszteles
{
    internal class Customer
    {
        public string firstName;
        public string lastName;
        //public string birthDate;
        public DateTime birthDate;
        public string email;

        public Customer(string fn, string ln, DateTime date, string email) {
            firstName = fn;
            lastName = ln;
            birthDate = date;
            this.email = email; 
        }

        public int GetAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        public bool IsEmailValid()
        {
            string[] st = email.Split('@');
            if(st.Length != 2) return false;
            if (st[0].Length == 0 || st[1].Length == 0) return false;
            string[] domain = st[1].Split('.');
            if (domain.Length!= 2) return false;
            if (!CsakSzamjegyeEsBetu(st[0]) || !CsakSzamjegyeEsBetu(domain[0]) || !CsakSzamjegyeEsBetu(domain[1]))
                return false;
            return true;
        }

        private bool CsakSzamjegyeEsBetu(string s)
        {
            int i = 0;
            while(i < s.Length && (char.IsLetter(s[i]) || char.IsNumber(s[i]))) 
                i++;
            return i >= s.Length;
        }

        public string GetFullName() {
            return lastName + " " + firstName;
        }

    }
}
