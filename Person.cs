using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCare
{
    public abstract class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        public string PhoneNumber { get; }
        public string EMail { get; }


        public Person(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string eMail)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.SocialSecurityNumber = socialSecurityNumber;
            this.PhoneNumber = phoneNumber;
            this.EMail = eMail;
           
        }


    }
}
