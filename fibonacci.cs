﻿using System;
namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 2, count, f1 = 0, f2 = 1, f3 = 0;
            Console.WriteLine("Enter the limit: ");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine(f1 + " ");
            Console.WriteLine(f2 + " ");
            do
            {
                f3 = f1 + f2;
                Console.Write("\n" + f3 + "\n");
                f1 = f2;
                f2 = f3;
                i++;
            }
            while (i <= count);
        }
    }
}
