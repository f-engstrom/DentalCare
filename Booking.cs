using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCare
{
    class Booking
    {
      public Patient Patient { get; }
        public string ReasonNote { get; }
        public Employee PeformingDoctor { get; }
        public DateTime DateofBooking { get; }


        public Booking(Patient patient, string reasonNote,
            Employee peformingDoctor, DateTime dateofBooking)
        {
            this.Patient = patient;
            this.ReasonNote = reasonNote;
            this.PeformingDoctor = peformingDoctor;
            this.DateofBooking = dateofBooking;

        }

        public override string ToString()
        {
            return Patient.FirstName + " " + Patient.LastName + ", " + Patient.SocialSecurityNumber + "    " + ReasonNote + "               " +
                   DateofBooking;
        }
    }
}
