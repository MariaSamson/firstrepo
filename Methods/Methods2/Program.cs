﻿using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please write a number");
            string firstNumber = Console.ReadLine();

            Console.WriteLine("Please write something");
            //scrierea in consola
            string lastNumber = Console.ReadLine();

            int number1= int.Parse(firstNumber);
            int number2 = int.Parse(lastNumber);

            Console.WriteLine("the sum is: " + (number1 + number2) + "?!");


        }
    }
}
