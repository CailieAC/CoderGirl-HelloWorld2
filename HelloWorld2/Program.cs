﻿using System;

namespace HelloWorld2
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("Please enter your name: ");

            // Store a name the user enters to a variable.
            string name = Console.ReadLine();
            // Output - Hello (name)!
            Console.WriteLine($"Hello {name}!");
            Console.ReadLine();

            string someString;
            int someInt;
            float someFloat;
            bool someBool;
            double someDouble = 11.2;
            char someChar = 'a';

        }
    }
}
