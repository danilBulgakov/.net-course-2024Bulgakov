using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSystem.Domain.Models;

namespace BankSystem.App.Services
{
    public class BankService
    {
        public static decimal profit { get; set;} //Банк один, поэтому переменная статичная
        public static decimal expenses {  get; set; } //Банк один, поэтому переменная статичная
        // Метод расчета зарплаты владельцев банка
        public static int CalculateOwnerSalary(decimal profit, decimal expenses, int ownerCount)
        {
            
            //Проверка
            if (ownerCount <= 0)
                throw new ArgumentException("Количество владельцев должно быть больше нуля.");

            decimal salary = (profit - expenses) / ownerCount;
            return (int)salary; // Приведение к целому числу
        }

        // Метод преобразования клиента в сотрудника
        public Employee ConvertClientToEmployee(Client client, string position, decimal salary, bool isowner)
        {
            // Преобразуем клиента в сотрудника
            Employee employee = new Employee(client.Name, client.Age, position, salary, isowner);
            if (isowner) {++Employee.ownerCount;}
            return employee;
        }
    }
}
