using System;
namespace C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "Advanced Web Programming";
            Console.WriteLine("Original string: " + a);

            Console.WriteLine("Length of string: " + a.Length);
            Console.WriteLine("Uppercase: " + a.ToUpper());
            Console.WriteLine("Lowercase: " + a.ToLower());

            string p = " Practical";
            string cat = string.Concat(a, p);
            Console.WriteLine("Concatenation: " + cat);
            string r = a.Replace("Advanced Web", "C#");
            Console.WriteLine("Replaced original string: " + r);
            
        }
    }
}
