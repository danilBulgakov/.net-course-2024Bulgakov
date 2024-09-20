using BankSystem.Domain.Models;

namespace BankSystem.Domain.Models
{
    //Базовый класс
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }


    //дочерний класс namespace BankSystem.Domain.Models
    public class Employee : Person
    {
        public string Position { get; set; }
        public decimal Salary { get; set; }
        public string Contract { get; set; }

        public Employee(string name, int age, string position, decimal salary, string contract = "")
            : base(name, age)
        {
            Position = position;
            Salary = salary;
            Contract = contract;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Position: {Position}, Salary: {Salary}, Contract: {Contract}");
        }
    }

    //Дочерний класс
    
        public class Client : Person
        {
            public string Company { get; set; }
            public decimal Balance { get; set; }

            public Client(string name, int age, string company, decimal balance)
                : base(name, age)
            {
                Company = company;
                Balance = balance;
            }

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Company: {Company}, Balance: {Balance}");
            }
        }
}



