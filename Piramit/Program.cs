using System;

namespace Piramit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("üçbucaq:");
            for (int i = 1; i <15; i++)
            {
                for (int j = i; j < 15; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
        
        }
    

