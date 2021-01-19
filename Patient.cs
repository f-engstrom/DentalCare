using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCare
{
    public class Patient : Person
    {


        public Patient(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string eMail) :
            base (firstName, lastName,  socialSecurityNumber,  phoneNumber,  eMail)
        {


        }

    }
}
