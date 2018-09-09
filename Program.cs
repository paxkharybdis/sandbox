﻿using System;
using System.Text;

namespace Sandbox
{
    class Program
    {
        // A construct that I can't put within STATIC VOID MAIN without red squiggly lines everywhere.  Even typing PUBLIC blows it all up.
        public class bicycle
        {
            public bool isAssembled;
            public bicycle()
            {
                isAssembled = false;
            }
        }

        // Generic private property I can't put within STATIC VOID MAIN without red squiggly lines everywhere.
        private int Wheels { set; get; } = 2;


        static void Main(string[] args)
        {

            bool tiresInflated = false;
            var tirePressure = "deflated";
            bool handlebars = false;
            var barsAligned = "not aligned";
            bool bikeAssembled = false;
            var bikeTogether = "not assembled";

            do
            {
                string userInput;

                Console.WriteLine("=======================================");
                Console.WriteLine("Bicycle Status");
                Console.WriteLine();
                Console.WriteLine("1. Check assembly status or assemble bike.");
                Console.WriteLine("2. Check handlebar alignment or align handlebars.");
                Console.WriteLine("3. Check tire status or inflate tires.");
                Console.WriteLine("4. Display overall bicycle status.");
                Console.WriteLine("5. Test bicycle.");
                Console.WriteLine("6. Exit Program.");
                Console.WriteLine();
                Console.WriteLine("Enter number to choose.");
                Console.WriteLine("=======================================");

                userInput = Console.ReadLine();


                switch (userInput)
                {
                    case "1":
                        if (bikeAssembled)
                        {
                            Console.WriteLine("Bike is assembled.");
                        }
                        else
                        {
                            Console.WriteLine("Bike has not been assembled.  Type ASSEMBLE to assemble bike.  Type EXIT to leave bike unassembled.");
                            string reply = Console.ReadLine();
                            switch (reply)
                            {
                                case "ASSEMBLE":
                                case "assemble":
                                case "Assemble":
                                    Console.WriteLine("Bike has been assembled");
                                    Console.WriteLine();
                                    bikeAssembled = true;
                                    bikeTogether = "assembled";
                                    break;
                                case "EXIT":
                                case "exit":
                                case "Exit":
                                    Console.WriteLine("Bike is still a pile of parts.");
                                    Console.WriteLine();
                                    break;
                                default:
                                    Console.WriteLine("Please enter ASSEMBLE or EXIT.");
                                    Console.WriteLine();
                                    break;
                            }

                        }
                        break;
                    case "2":
                        if (bikeAssembled)
                        {
                            if (handlebars)
                            {
                                Console.WriteLine("Handlebars are aligned.");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Handlebars are not aligned.  Type ALIGN to align them.  Type EXIT to keep handlebars unaligned.");
                                string reply = Console.ReadLine();
                                switch (reply)
                                {
                                    case "ALIGN":
                                    case "align":
                                    case "Align":
                                        Console.WriteLine("Handlebars are aligned.");
                                        Console.WriteLine();
                                        handlebars = true;
                                        barsAligned = "inflated";
                                        break;
                                    case "EXIT":
                                    case "exit":
                                    case "Exit":
                                        Console.WriteLine("Handlebars are still misaligned.");
                                        Console.WriteLine();
                                        break;
                                    default:
                                        Console.WriteLine("Please enter ALIGN or EXIT.");
                                        Console.WriteLine();
                                        break;
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Bike has not been assembled.  Please assemble bicycle.");
                            Console.WriteLine();
                        }   
                            break;
                       case "3":
                        if (bikeAssembled)
                        {
                            if (tiresInflated)
                            {
                                Console.WriteLine("Tires are inflated.");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.WriteLine("Tires are not inflated.  Type INFLATE to inflate them.  Type EXIT to keep tires deflated.");
                                string reply = Console.ReadLine();
                                switch (reply)
                                {
                                    case "INFLATE":
                                    case "inflate":
                                        Console.WriteLine("Tires have been inflated");
                                        Console.WriteLine();
                                        tiresInflated = true;
                                        tirePressure = "inflated";
                                        break;
                                    case "EXIT":
                                    case "exit":
                                        Console.WriteLine("Tires are still deflated.");
                                        Console.WriteLine();
                                        break;
                                    default:
                                        Console.WriteLine("Please enter INFLATE or EXIT.");
                                        Console.WriteLine();
                                        break;
                                }

                            }
                        }
                        else
                        {
                            Console.WriteLine("Bike has not been assembled.  Please assemble bicycle.");
                            Console.WriteLine();
                        }
                        break;
                    case "4":
                        Console.WriteLine("Bike is {0}.", bikeTogether);
                        Console.WriteLine("Handlebars are {0}.", barsAligned);
                        Console.WriteLine("Tires are currently {0}.", tirePressure);
                        Console.WriteLine();
                        break;
                    case "5":
                        if (bikeAssembled && handlebars && tiresInflated)
                        {
                            Console.WriteLine("Everything works well.");
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Bike is not ready for testing.  Select option 4 at menu to display overall status.");
                            Console.WriteLine();
                        }
                        break;
                    case "6":
                        Console.WriteLine("Thank you for using Virtual Bicycle Assistant.  $3600.00 has been charged to your account.");
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            } while (true);

        }

    }


}

