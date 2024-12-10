using System;
using System.Text.RegularExpressions;

namespace _2024_11_27_UgyfelosztalyEsTeszteles
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }

        // Konstruktor
        public Customer(string firstName, string lastName, DateTime birthDate, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            Email = email;
        }

        // Életkor kiszámítása
        public int GetAge()
        {
            var today = DateTime.Today;
            var age = today.Year - BirthDate.Year;
            if (BirthDate.Date > today.AddYears(-age)) age--;
            return age;
        }

        // E-mail cím validálása
        public bool IsEmailValid()
        {
            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(Email, emailPattern);
        }

        // Teljes név visszaadása
        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }
    }
}