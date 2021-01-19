using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCare
{
    class Dentist : Employee
    {
        public Dentist(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string eMail,
            string employeeId, string employeeSalary)
            : base(firstName, lastName, socialSecurityNumber, phoneNumber, eMail, employeeId, employeeSalary)
        {


        }




        public override string ToString()
        {
            return FirstName + " " + LastName + ", " + "Tandläkare";
            
        }
    }
}
