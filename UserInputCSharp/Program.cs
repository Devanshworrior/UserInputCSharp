﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInputCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter username : ");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username is: " + userName);
            Console.ReadLine();
        }
    }
}
