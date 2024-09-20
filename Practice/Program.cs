using System;
using BankSystem.Domain.Models;

namespace Practice
{
    public class Program
    {
        // Метод обновления контракта сотрудника
        public static void UpdateEmployeeContract(Employee employee)
        {
            employee.Contract = $"Contract for {employee.Position} with salary {employee.Salary}";
            Console.WriteLine($"контракт с сотрудником {employee.Name} подписан.");
        }

        // Метод обновления валюты
        public static void UpdateCurrency(ref Currency currency, string newCode, decimal newExchangeRate)
        {
            currency.Code = newCode;
            currency.ExchangeRate = newExchangeRate;
            Console.WriteLine("Currency updated successfully.");
        }
        // А вот тут мы наконец-то что-то делаем
        public static void Main()
        {
        //    // Пример использования классов из BankSystem.Domain
        //    Employee employee = new Employee("Alice", 28, "Developer", 75000);
        //    UpdateEmployeeContract(employee);
        //    employee.DisplayInfo();

        //    Currency usd = new Currency("USD", 1.0m);
        //    UpdateCurrency(ref usd, "EUR", 1.12m);
        //    usd.DisplayCurrencyInfo();
        }
    }
}