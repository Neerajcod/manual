﻿using System;
namespace P19
{
    class ADD
    {
        int x, y;
        double f;
        string s;
        public ADD(int a, double b)
        {
            x = a;
            f = b;
        }
        public ADD(int a, string b)
        {
            y = a;
            s = b;
        }
        public void show()
        {
            Console.WriteLine("1st Constructor (int+float):{0}", (x + f));
        }
        public void show1()
        {
            Console.WriteLine("2nd Constructor (int+string):{0}", (s + y));
        }
    }
    class CFG
    {
        static void Main()
        {
            ADD g = new ADD(10, 20.2);
            g.show();
            ADD q = new ADD(10, "don");
            q.show1();
        }
    }
}
