
// Напишете програма, която отпечатва на конзолата числата от 1 до N, които не се делят едновременно на 3 и 7. Числото N да се чете от стандартния вход.

using System;

namespace Zad._2
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Брой числа: ");
            int br = int.Parse(Console.ReadLine());
              for (int i = 1; i <= br; i++)
              {
                if (i % 21 != 0)
                {
                    Console.WriteLine(" {0}", i);
                }
              }
        }
    }
}

