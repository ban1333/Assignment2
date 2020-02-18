using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROG2070Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continueApplication = true;

            do
            {

                MainMenu();
                string strUserInput = GetUserInput();
                int selectedMenuOption = 0;
                bool isNumber = int.TryParse(strUserInput, out selectedMenuOption);

                if (isNumber)
                {
                    //happy path
                    if (selectedMenuOption > 0 && selectedMenuOption <= 2)
                    {
                        //happy path
                        switch (selectedMenuOption)
                        {
                            case 1:

                                Console.Clear();
                                bool error = false;
                                strUserInput = "";
                                int firstDimension = 0;
                                int secondDimension = 0;
                                int thirdDimension = 0;

                                do
                                {
                                    Console.Write("Enter the triangle's First Dimension: ");
                                    strUserInput = GetUserInput();
                                    error = !int.TryParse(strUserInput, out firstDimension);
                                    if(error)
                                    {
                                        error = true;
                                        Console.WriteLine($"ERROR - {strUserInput} is not a valid number");
                                    }
                                    else
                                    {
                                        error = false;
                                    }
                                } while (error);

                                do
                                {
                                    Console.Write("Enter the triangle's Second Dimension: ");
                                    strUserInput = GetUserInput();
                                    error = !int.TryParse(strUserInput, out secondDimension);
                                    if (error)
                                    {
                                        error = true;
                                        Console.WriteLine($"ERROR - {strUserInput} is not a valid number");
                                    }
                                    else
                                    {
                                        error = false;
                                    }
                                } while (error);

                                do
                                {
                                    Console.Write("Enter the triangle's Third Dimension: ");
                                    strUserInput = GetUserInput();
                                    error = !int.TryParse(strUserInput, out thirdDimension);
                                    if (error)
                                    {
                                        error = true;
                                        Console.WriteLine($"ERROR - {strUserInput} is not a valid number");
                                    }
                                    else
                                    {
                                        error = false;
                                    }
                                } while (error);



                                break;
                            case 2:
                                continueApplication = false;
                                break;
                        }
                    }
                    else
                    {
                        //sad path
                        Console.WriteLine($"ERROR - {selectedMenuOption} is not a menu option");
                    }
                }
                else
                {
                    //sad path
                    Console.WriteLine($"ERROR - Valid number not entered");
                }

            } while (continueApplication);
        }

        /// <summary>
        /// displays the main menu
        /// </summary>
        private static void MainMenu()
        {
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit");
            Console.Write("Enter a menu option: ");
        }

        /// <summary>
        /// returns the string value of what the user entered
        /// </summary>
        /// <returns></returns>
        private static string GetUserInput()
        {
            string userInput = "";

            userInput = Console.ReadLine();

            return userInput;
        }
    }
}
