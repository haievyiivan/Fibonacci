using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buffer varibales
            ulong a = 0; // Set 0 (first num)
            ulong b = 1; // Set 1 (second num)

            // Num
            ulong c;

            // Write two first numbers to the console
            Console.WriteLine($"1. {a}");
            Console.WriteLine($"2. {b}");

            // Loop
            for (int i = 3; i <= 120/*Number of numbers*/; i++)
            {
                c = a + b; // Calculate next num

                Console.WriteLine($"{i}. {c}");
                if (c < a || c < b)
                {
                    Console.WriteLine("^ ERROR - The number is so big. High chance of wrong answer");
                    break;
                }
                
                // Change buffer variables
                a = b;
                b = c;
            }

            // ReadKey
            Console.ReadKey();
        }
    }
}
