﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
namespace awp
{
    class Program
    {
        public static void Main(String[] args)
        {
            int choice;
            Console.WriteLine("Enter the choice:\n 1) celcius to farenheit .\n 2) farenhite to celcius ");
            choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                Console.WriteLine("Enter the temperature in celcius: ");
                double celcius=double.Parse(Console.ReadLine());
                double far=(celcius*9)/5+32;
                Console.WriteLine("Temperature in farenheit is : "+far);
                break;

                case 2:
                Console.WriteLine("Enter the temperature in farenheit: ");
                Double faren=Double.Parse(Console.ReadLine());
                double cel=(faren-32)/1.8;
                Console.WriteLine("Temperature in celcius is : "+cel);
                break;
            }
        }
}
}
