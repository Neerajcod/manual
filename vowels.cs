﻿using System;
namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n");

            Console.WriteLine("Enter any string: ");
            string myStr = Console.ReadLine();
            Console.WriteLine("Vowels are: ");
            for (int i = 0; i < myStr.Length; i++)
            {
                if (myStr[i] == 'a' || myStr[i] == 'e' || myStr[i] == 'i' || myStr[i] == 'o' || myStr[i] == 'u' || myStr[i] == 'A' || myStr[i] == 'E' || myStr[i] == 'I' || myStr[i] == 'O' || myStr[i] == 'U')
                {
                    Console.Write(myStr[i]);
                }
            }
            Console.WriteLine("\n");
        }
    }
}
