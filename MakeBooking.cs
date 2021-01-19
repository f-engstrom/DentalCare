using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DentalCare
{
    public class MakeBooking
    {
        List<Booking> myBookings = new List<Booking>();


        public void MakeABooking()
        {
            ConsoleKeyInfo keyPressed;
            bool invalidKeyPress = true;
            bool validBooking = false;

            do
            {

                Console.SetCursorPosition(5, 7);
                Console.WriteLine("Kund (Personummer): ");
                Console.SetCursorPosition(5, 9);
                Console.WriteLine("Anledning: ");
                Console.SetCursorPosition(5, 11);
                Console.WriteLine("Utförs av (ID): ");
                Console.SetCursorPosition(5, 13);
                Console.WriteLine("Datum ( yyyy-mm-dd hh:mm): ");
                Console.SetCursorPosition("Kund (Personummer): ".Length + 4, 7);
                string socialSecurityNumber = Console.ReadLine();
                Console.SetCursorPosition("Anledning: ".Length + 4, 9);
                string reasonNote = Console.ReadLine();
                Console.SetCursorPosition("Utförs av (ID): ".Length + 4, 11);
                string performingDoctor = Console.ReadLine();
                Console.SetCursorPosition("Datum ( yyyy-mm-dd hh:mm): ".Length + 4, 13);
                DateTime dateofBooking = DateTime.Parse(Console.ReadLine());



                Console.WriteLine("\nÄr detta rätt? (J)a (N)ej");


                do
                {
                    keyPressed = Console.ReadKey(true);

                    invalidKeyPress = !(keyPressed.Key == ConsoleKey.J || keyPressed.Key == ConsoleKey.N);

                } while (invalidKeyPress);



                if (keyPressed.Key == ConsoleKey.J)
                {
                    if (RegisterPerson.MyEmployees.ContainsKey(performingDoctor)&& RegisterPerson.MyPatients.ContainsKey(socialSecurityNumber))
                    {
                        myBookings.Add(new Booking(patient:RegisterPerson.MyPatients[socialSecurityNumber],
                            reasonNote: reasonNote, 
                            peformingDoctor: RegisterPerson.MyEmployees[performingDoctor], 
                            dateofBooking: dateofBooking));
                        Console.Clear();
                        Console.WriteLine("Bokning skapad");
                        validBooking = true;
                        Thread.Sleep(1000);

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Ogiltig anställd eller personal");
                        validBooking = true;
                        Thread.Sleep(1000);
                    }


                }
                if (keyPressed.Key == ConsoleKey.N)
                {
                    Console.Clear();

                }

            } while (!validBooking);


        }

        public void ListBookings()
        {

            Console.WriteLine("Patient".PadRight(20, ' ') + "Anledning".PadRight(20, ' ') + "Tid");
            Console.WriteLine(" ".PadLeft(50, '-'));

            foreach (var booking in myBookings)
            {
                Console.WriteLine(booking.ToString());
            }

            Console.ReadKey();
        }



    }
}
