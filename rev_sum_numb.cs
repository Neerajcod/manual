﻿using System;
public class ReverseSumExample
{
    static public void Main()
    {
        int n, reverse = 0, rem, sum = 0;
        Console.WriteLine("Enter a number : ");
        n = int.Parse(Console.ReadLine());
        while(n != 0)
        {
            rem = n % 10;
            sum = sum + rem;
            reverse = reverse * 10 + rem;
            n /= 10;     
        }
        Console.WriteLine("sum of digits:" + sum);
        Console.WriteLine("Reverse of number :" + reverse);
    }
}
