﻿//Single Inheritance
using System;
namespace P17
{
    class Animal //base
    {
        public string name;
        public void display()
        {
            Console.WriteLine("I am an Animal");
        }
    }
    class Dog : Animal  //derived
    {
        public void getName()
        {
            Console.WriteLine("My name is " + name);
        }
    }
    class Program
    {
        static void Main(String[] args)
        {
            Dog husky = new Dog();
            husky.name = "Tommy";
            husky.display();
            husky.getName();
            Console.ReadLine();
        }
    }
}
