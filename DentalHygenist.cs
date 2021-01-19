using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCare
{
    class DentalHygenist : Employee
    {

        public DentalHygenist(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string eMail,
            string employeeId, string employeeSalary)
            : base(firstName, lastName, socialSecurityNumber, phoneNumber, eMail, employeeId, employeeSalary)
        {


        }



        public override string ToString()
        {
            return FirstName + " " + LastName + ", " + "Tandhygenist";
        }
    }
}
