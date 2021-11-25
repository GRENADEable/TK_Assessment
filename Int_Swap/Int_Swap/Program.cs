﻿using System;

namespace Int_Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;

            Console.WriteLine("Intial Value A");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Intial Value B");
            b = int.Parse(Console.ReadLine());

            Confirmation(a, b);
            Swap(a, b);
        }

        static void Confirmation(int a, int b) // Confirms Numbers Before Switching;
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"Value of A = {a}");
            Console.WriteLine($"Value of B = {b}");
            Console.WriteLine("-------------------");
            Console.WriteLine("Press Enter to Swap Numbers");
            Console.ReadLine();
        }

        static void Swap(int a, int b) // Swaps the Values;
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"Value of A = {b}");
            Console.WriteLine($"Value of B = {a}");
            Console.WriteLine("-------------------");
            Console.WriteLine("Press Enter to Exit");
            Console.ReadLine();
        }
    }
}
