using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;

namespace DentalCare
{
    public static class RegisterPerson
    {
        public static Dictionary<string, Patient> MyPatients { get; } = new Dictionary<string, Patient>();
        public static Dictionary<string, Employee> MyEmployees { get; } = new Dictionary<string, Employee>();


        public static void RegisterPatient()
        {

            ConsoleKeyInfo keyPressed;
            bool invalidKeyPress = true;
            bool validBooking = false;

            do
            {

                Console.Clear();

                Console.SetCursorPosition(5, 7);
                Console.WriteLine("Förnamn: ");
                Console.SetCursorPosition(5, 9);
                Console.WriteLine("Efternamn: ");
                Console.SetCursorPosition(5, 11);
                Console.WriteLine("Personnummer: ");
                Console.SetCursorPosition(5, 13);
                Console.WriteLine("Telefonnummer: ");
                Console.SetCursorPosition(5, 15);
                Console.WriteLine("Mail: ");
                Console.SetCursorPosition(5, 17);
                Console.SetCursorPosition("Förnamn: ".Length + 4, 7);
                string firstName = Console.ReadLine();
                Console.SetCursorPosition("Efternamn: ".Length + 4, 9);
                string lastName = Console.ReadLine();
                Console.SetCursorPosition("Personnummer: ".Length + 4, 11);
                string socialSecurityNumber = Console.ReadLine();
                Console.SetCursorPosition("Telefonnummer: ".Length + 4, 13);
                string phoneNumber = Console.ReadLine();
                Console.SetCursorPosition("Mail: ".Length + 4, 15);
                string eMail = Console.ReadLine();



                Console.WriteLine("\nÄr detta rätt? (J)a (N)ej");


                do
                {
                    keyPressed = Console.ReadKey(true);

                    invalidKeyPress = !(keyPressed.Key == ConsoleKey.J || keyPressed.Key == ConsoleKey.N);

                } while (invalidKeyPress);



                if (keyPressed.Key == ConsoleKey.J)
                {
                    try
                    {
                        MyPatients.Add(socialSecurityNumber, new Patient(firstName: firstName, lastName: lastName,
                            socialSecurityNumber: socialSecurityNumber, phoneNumber: phoneNumber, eMail: eMail));
                        Console.Clear();
                        Console.WriteLine("Patient registrerad");
                        validBooking = true;
                        Thread.Sleep(1000);

                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("Patienten är redan registrerad");
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


        public static void RegisterEmployee()
        {

            ConsoleKeyInfo keyPressed;
            bool invalidKeyPress = true;
            bool validBooking = false;
            int employeeChoice = 0;

            do
            {

                Console.Clear();

                Console.SetCursorPosition(5, 7);
                Console.WriteLine("Förnamn: ");
                Console.SetCursorPosition(5, 9);
                Console.WriteLine("Efternamn: ");
                Console.SetCursorPosition(5, 11);
                Console.WriteLine("Personnummer: ");
                Console.SetCursorPosition(5, 13);
                Console.WriteLine("Telefonnummer: ");
                Console.SetCursorPosition(5, 15);
                Console.WriteLine("Mail: ");
                Console.SetCursorPosition(5, 17);
                Console.WriteLine("ID: ");
                Console.SetCursorPosition(5, 19);
                Console.WriteLine("Lön: ");

                Console.WriteLine("(1) Tandläkare (2) Tandhygienist");

                Console.SetCursorPosition("Förnamn: ".Length + 4, 7);
                string firstName = Console.ReadLine();
                Console.SetCursorPosition("Efternamn: ".Length + 4, 9);
                string lastName = Console.ReadLine();
                Console.SetCursorPosition("Personnummer: ".Length + 4, 11);
                string socialSecurityNumber = Console.ReadLine();
                Console.SetCursorPosition("Telefonnummer: ".Length + 4, 13);
                string phoneNumber = Console.ReadLine();
                Console.SetCursorPosition("Mail: ".Length + 4, 15);
                string eMail = Console.ReadLine();
                Console.SetCursorPosition("ID: ".Length + 4, 17);
                string employeeId = Console.ReadLine();
                Console.SetCursorPosition("Lön: ".Length + 4, 19);
                string employeeSalary = Console.ReadLine();


                do
                {
                    keyPressed = Console.ReadKey(true);

                    invalidKeyPress = !(keyPressed.Key == ConsoleKey.D1 || keyPressed.Key == ConsoleKey.D2);

                } while (invalidKeyPress);

                if (keyPressed.Key == ConsoleKey.D1)
                {
                    employeeChoice = 1;


                }
                if (keyPressed.Key == ConsoleKey.D2)
                {
                    employeeChoice = 2;

                }

                Console.WriteLine($"Roll: {employeeChoice}");


                Console.WriteLine("\nÄr detta rätt? (J)a (N)ej");


                do
                {
                    keyPressed = Console.ReadKey(true);

                    invalidKeyPress = !(keyPressed.Key == ConsoleKey.J || keyPressed.Key == ConsoleKey.N);

                } while (invalidKeyPress);



                if (keyPressed.Key == ConsoleKey.J)
                {
                    try
                    {
                        if (employeeChoice == 1)
                        {
                            MyEmployees.Add(employeeId, new Dentist(firstName: firstName, lastName: lastName,
                                socialSecurityNumber: socialSecurityNumber, phoneNumber: phoneNumber, eMail: eMail, employeeId, employeeSalary));
                            Console.Clear();
                            Console.WriteLine("Tandläkare registrerad");
                            validBooking = true;
                            Thread.Sleep(1000);

                        }
                        else if (employeeChoice == 2)
                        {
                            MyEmployees.Add(employeeId, new DentalHygenist(firstName: firstName, lastName: lastName,
                                socialSecurityNumber: socialSecurityNumber, phoneNumber: phoneNumber, eMail: eMail, employeeId, employeeSalary));
                            Console.Clear();
                            Console.WriteLine("Tandhygienist registrerad");
                            validBooking = true;
                            Thread.Sleep(1000);
                        }

                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("Anställd är redan registrerad");
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


        public static void ListEmployees()
        {

            Console.WriteLine("Anställd".PadRight(30,' ') +  "ID");
            Console.WriteLine(" ".PadLeft(50,'-'));

            foreach (var employee in MyEmployees)
            {
                Console.WriteLine(employee.ToString());
            }

            Console.ReadKey();
        }

    }
}
