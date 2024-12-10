using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024_11_20_LINQ
{
    internal class Program
    {
        static List<BankAccount> customers;
        static void Main(string[] args)
        {
            Adatok();

            Atvaltasok();

            LinqEgyszeruPelda();

            LinqSzerekezet();

            AggregatumOperatorok();


            Console.ReadLine();
        }

        private static void AggregatumOperatorok()
        {
            //Sum, Avarge, Min, Max, Count, Distinct

            //double sum = customers.Sum(c=>c.Balance);

            //double sum = (from c in customers
            //              select c.Balance).Sum();

            //Console.WriteLine($"Az egyenleg teljes összege: {sum}");
            //Console.WriteLine($"Az egyenleg teljes összege: {customers.Sum(c=>c.Balance)}");

            var egyediEgyenlegek = customers.Select(c=>c.Balance).Distinct();
            Console.WriteLine();
            foreach(var c in egyediEgyenlegek)
                Console.WriteLine(c);

        }

        private static void LinqSzerekezet()
        {
            //customers

            var queryResults = from x in customers
                               where x.Balance >= 0
                               select x;

            foreach (var item in queryResults)
                Console.WriteLine(item);

            //Lambda - Csak az objektumokat
            //var queryResultsLambda = customers.Where(x => x.Balance > 500);  

            //Lambda - az objektumokból a neveket szűri ki
            var queryResultsLambda = customers.Where(x => x.Balance > 500).Select(c => c.Name);

        }

        private static void LinqEgyszeruPelda()
        {
            List<int> numbers = new List<int> {1,2,3,4,5,6};

            //LINQ - Lekérdezés minta
            var queryResults = from x in numbers
                               where x > 3
                               select x;

            List<int> slista = queryResults.ToList();

            //Lambda kifejezés
            var queryResultsLambda = numbers.Where(x => x > 3);
            List<int> slista2 = queryResultsLambda.ToList();

            //List<int> slista3 = numbers.Where(x => x > 3).ToList();
        }

        private static void Atvaltasok()
        {
            BankAccount[] ArrayBank = customers.ToArray();
            HashSet<BankAccount> SetBank = customers.ToHashSet();
        }

        private static void Adatok()
        {

            customers = new List<BankAccount>()
            {
                new BankAccount("John Doe", 1000.0, "123-456-789"),
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
