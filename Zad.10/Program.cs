
// Напишете програма, която чете от конзолата положително цяло число N (N < 20) и отпечатва матрица с числа като на фигурата по-долу:

using System;

namespace Zad._10
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число N(N < 20): ");
            int n = int.Parse(Console.ReadLine());
             if (n<20)
             { 
               for (int i = 1; i <= n; i++)
               {
                  for (int b = i; b <= (i + n - 1); b++)
                  {
                    Console.Write("{0,3} ", b);
                  }
                 Console.WriteLine();
               }
             }
             else
             {
                Console.WriteLine(" Невалидно число !");
             }
        }
    }
}

