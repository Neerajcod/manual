﻿using System;
namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, count;
            Console.WriteLine("Enter a number: ");
            count = int.Parse(Console.ReadLine());
            for (i = 2; i <= count; i++)
            {
                if ((count % i) == 0)
                    break;
            }
            if (count == 1)
            {
                Console.WriteLine(count + " is neither prime not composite");
            }
            else if (i < count - 1)
            {
                Console.WriteLine(count + " is a composite number.");
            }
            else
            {
                Console.WriteLine(count + " is a prime number.");
            }
        }
    }
}
