﻿using System;
namespace P1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 4 intergers:");
            int a= int.Parse(Console.ReadLine());
            int b= int.Parse(Console.ReadLine());
            int c= int.Parse(Console.ReadLine());
            int d= int.Parse(Console.ReadLine());
            int e= a*b*c*d;
            Console.WriteLine("Product of Numbers=" +e);
        }
    }
}
