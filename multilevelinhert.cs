﻿//Multilevel Inheritance
using System;
namespace P18
{
	class Grandfather
    {
        public void display()
        {
            Console.WriteLine("Grandfather.....");
        }
    }
    class Father : Grandfather
    {
        public void displayone()
        {
            Console.WriteLine("Father.....");
        }
    }
    class Son : Father
    {
        public void displaytwo()
        {
            Console.WriteLine("Son....");
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Son s = new Son();
            s.display();
            s.displayone();
            s.displaytwo(); 
            Console.ReadLine();
        }
    }
}
