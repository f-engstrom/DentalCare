using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace DentalCare
{
    class Menu
    {
        public static void DentalCare()
        {
            MakeBooking myBooking = new MakeBooking();

            bool shouldNotExit = true;

            while (shouldNotExit)
            {

                Clear();


                WriteLine("1.Skapa bokning");
                WriteLine("2.Lista bokningar");
                WriteLine("3.Registrera patient");
                WriteLine("4. Registrera anställd");
                WriteLine("5. Lista anställda");
                WriteLine("6. Avsluta");

                ConsoleKeyInfo keyPressed = ReadKey(true);


                switch (keyPressed.Key)
                {

                    case ConsoleKey.D1:
                        Clear();
                        myBooking.MakeABooking();

                        break;

                    case ConsoleKey.D2:

                        Clear();
                        myBooking.ListBookings();

                        break;

                    case ConsoleKey.D3:
                        RegisterPerson.RegisterPatient();
                        break;

                    case ConsoleKey.D4:
                        RegisterPerson.RegisterEmployee();
                        break;

                    case ConsoleKey.D5:

                        RegisterPerson.ListEmployees();
                        break;

                    case ConsoleKey.D6:

                        shouldNotExit = false;

                        break;
                }

            }
        }


    }
}
