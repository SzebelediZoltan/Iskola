using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _2024_12_04_LINQqueries
{
    internal class Program
    {
        static List<BankAccount> customers;
        static void Main(string[] args)
        {



            Adatok();
            //SortList();
            SortTask();
            //A számlaszám utolsó 3 karaktere alapján rendezze!

            //Any - Van-e
            AnyTask();
            AllTask();

            SelectManyExample2();

            Console.ReadLine();
        }

        private static void SelectManyExample2()
        {
            List<List<int>> t = new List<List<int>>
            {
                new List<int>() {1, 2, 3 },
                new List<int>() {4, 5, 6 },
                new List<int>() {8, 7, 9 }
            };

            var numbers = t.SelectMany(c => c);
            foreach (var item in numbers)
            {
                Console.Write(item+ " ");
            }

        }

        class PetOwner
        {
            public string Name { get; set; }
            public List<String> Pets { get; set; }
        }


        private static void AllTask()
        {
            // Egy bizonyos tulajdonság igaz-e az összes elemre!
            // Az összes számlaszám tartalmaz-e kötőjelet? 
            // Nincs olyan elem, amire nem igaz a feltétel!
            //customers.Clear();
            bool isAllTrue = customers.All(c => c.AccountNumber.Contains("-"));
            Console.WriteLine("Mindben van-e kötőjel: "+ isAllTrue);
        }

        private static void AnyTask()
        {
            //Van-e a számlaszámok között olyan, ami tartalmazza az 123 számsort?
            //customers.Any() - üres-e a lista
            bool isThere = customers.Any(c=>c.AccountNumber.Contains("123"));
            //bool isThere2 = customers.Where(c => c.AccountNumber.Contains("123")).Count() > 0;
            //Van-e olyan számla, ahol a számlaszám szerkezete 3 résznél több?
            //bool isThere2 = customers.Any(c => c.AccountNumber.Split('-').Length > 3);

        }

        private static void SortTask()
        {
            var names = customers.Select(x => x.Name.Split(' ')[0]).OrderBy(x => x);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }

        private static void SortList()
        {
            //Lambda
            //var sortedList = customers.OrderBy(c => c.Balance);
            var sortedList = customers.OrderBy(c => c.Balance).ThenByDescending(c => c.Name);

            //var sortedList = from c in customers
            //                 orderby c.Balance descending, c.Name descending
            //                 select c;

            foreach (var item in sortedList)
            {
                Console.WriteLine(item);
            }
        }

        private static void Adatok()
        {

            customers = new List<BankAccount>()
            {
                new BankAccount("John Doe", 5000.0, "123-456-789"),
                new BankAccount("Alice Smith", 0.0, "987-654-321"),
                new BankAccount("Robert Johnson", 1000000.0, "555-123-999"),
                new BankAccount("Sarah White", 50.5, "666-777-888"),
                new BankAccount("Superman", 5000.0, "000-000-001"),
                new BankAccount("Bruce Wayne", 0.0, "111-222-333"),
                new BankAccount("Peter Parker", 1200.75, "444-555-666"),
                new BankAccount("Tony Stark", 99999999.99, "1234-5678-9012-3456")
            };
            //customers.Add(customers[0]);
        }
    }
    class BankAccount
    {
        public string Name { get; private set; }
        public double Balance { get; private set; } //egyenleg
        public string AccountNumber { get; private set; }

        public BankAccount(string name, double balance, string accountNumber)
        {
            Name = name;
            Balance = balance;
            AccountNumber = accountNumber;
        }

        public override string ToString()
        {
            return $"Name: {Name} Balance: {Balance} AccountNumber: {AccountNumber}";
        }
    }
}
