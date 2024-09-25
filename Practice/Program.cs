using System;
using BankSystem.Domain.Models;
using BankSystem.App.Services;
using System.Collections.Generic;

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
        public static void Main(string[] args)
        {
            //Создаем экземпляр класса BankService
            BankService bankService = new BankService();

            // Пример списка сотрудников
            Employee employees = new("Alice", 30, "Developer", 75000, true, "");

            // Пример расчета зарплаты владельцев банка
            BankService.profit = 1000000m;  // Прибыль банка
            BankService.expenses = 400000m; // Расходы банка

            try
            {
                int ownerSalary = BankService.CalculateOwnerSalary(BankService.profit, BankService.expenses, Employee.ownerCount);
                Console.WriteLine($"Зарплата владельца банка: {ownerSalary}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                //    // Используем классы из BankSystem.Domain
                //    Employee employee = new Employee("Alice", 28, "Developer", 75000);
                //    UpdateEmployeeContract(employee);
                //    employee.DisplayInfo();

                //    Currency usd = new Currency("USD", 1.0m);
                //    UpdateCurrency(ref usd, "EUR", 1.12m);
                //    usd.DisplayCurrencyInfo();
            }
        }
    }
}