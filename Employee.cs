using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCare
{
    public abstract class Employee : Person
    {
        public string EmployeeId { get; }
        public string EmployeeSalary { get; }

        public Employee(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string eMail,string employeeId, string employeeSalary) :
            base(firstName, lastName, socialSecurityNumber, phoneNumber, eMail)
        {
            this.EmployeeId = employeeId;
            this.EmployeeSalary = employeeSalary;

        }


    }
}
