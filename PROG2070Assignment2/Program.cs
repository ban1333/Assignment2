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
            Console.Write("Enter the triangle's First Dimension: ");
            GetUserInput();
            Console.Write("Enter the triangle's Second Dimension: ");
            GetUserInput();
            Console.Write("Enter the triangle's Third Dimension: ");
            GetUserInput();
        }

        /// <summary>
        /// displays the main menu
        /// </summary>
        private static void MainMenu()
        {
            Console.WriteLine("1. Enter triangle dimensions");
            Console.WriteLine("2. Exit");
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
