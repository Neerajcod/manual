﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace awp
{
    class Program
    {
        public static void Main(String[] args)
        {
            int choice;
            Console.WriteLine("Enter the choice:\n 1) dollar to rupee.\n 2) Euro to rupee.\n 3) Baht to Rupee.");
            choice=int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                Double dollar,rupee,val=82.03;
                Console.WriteLine("Enter the dollar amount: ");
                dollar=Double.Parse(Console.ReadLine());
                rupee=dollar*val;
                Console.WriteLine(rupee);
                break;
            
                case 2:
                Double euro,rupe,valu=92.32;
                Console.WriteLine("Enter the Euro amount: ");
                euro=Double.Parse(Console.ReadLine());
                rupe=euro*valu;
                Console.WriteLine(rupe);
                break;

                case 3:
                Double baht, rup, value=2.73;
                Console.WriteLine("Enter the baht Amount :");
                baht = Double.Parse(Console.ReadLine());
                rup = baht * value;
                Console.WriteLine("{0} Thiland baht Equals {1} Rupees", baht, rup);
                break;
            }
        }
}
}
