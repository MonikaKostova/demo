﻿using System;

namespace _04._Even_Powers_of_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for (int power = 0; power <= n; power++)            
            {
                if (power % 2 == 0)
                {
                    Console.WriteLine(Math.Pow(2,power));
                }
                //ili
                //for (int power = 0; power <= n; power+=2) 
                //bez posledvasht if

            }
        }
    }
}
