﻿using System;
public class Demo
{
    public static int mulDisplay(int f, int s)
    {
        return f * s;
    }

    public static int mulDisplay(int f, int s, int t)
    {
        return f * s * t;
    }

    public static int mulDisplay(int f, int s, int t, int r)
    {
        return f * s * t * r;
    }
}

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Multiplication of two numbers: " + Demo.mulDisplay(10, 15));
        Console.WriteLine("Multiplication of three numbers: " + Demo.mulDisplay(5, 10, 15));
        Console.WriteLine("Multiplication of four numbers: " + Demo.mulDisplay(5, 10, 15, 20));
    }
}
