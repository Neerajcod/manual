﻿//Heirarchical Inheritance
using System;
namespace P19
{
    class Principal
    {
        public void display()
        {
            Console.WriteLine("Monitor");
        }
    }
    class Teacher : Principal
    {
        public void displayone()
        {
            Console.WriteLine("Teach");
        }
    }
    class Student : Principal
    {
        public void displaytwo()
        {
            Console.WriteLine("Learn");
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Principal g = new Principal();
            g.display();
            Teacher d = new Teacher();
            d.display();
            d.displayone();
            Student s = new Student();
            s.display();
            s.displaytwo();
            Console.ReadLine();
        }
    }
}
