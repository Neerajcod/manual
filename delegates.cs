﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace C_
{
    delegate void MyDelegate(int x, int y);
    public class Calculatedeligate
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("Addition is=" + (x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("Subtraction is=" + (x - y));
        }
        public static void Multiply(int x, int y)
        {
            Console.WriteLine("Multiply is=" + (x * y));
        }
        public static void Division(int x, int y)
        {
            Console.WriteLine("Division is=" + (x / y));
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            MyDelegate obj = new MyDelegate(Calculatedeligate.Add);
            obj(6, 4);
            MyDelegate obj1 = new MyDelegate(Calculatedeligate.Sub);
            obj1(2, 5);
            MyDelegate obj2 = new MyDelegate(Calculatedeligate.Multiply);
            obj2(6, 4);
            MyDelegate obj3 = new MyDelegate(Calculatedeligate.Division);
            obj3(6, 4);
            Console.WriteLine("\n");
        }
    }
}
