
// Напишете програма, която пресмята N!*K!/(N-K)! за дадени N и K (1<K<N).

using System;

namespace Zad._7
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете N-то Kaталаново число: ");
            double n = double.Parse(Console.ReadLine());
            double c;
              if (n>=0)
              {
                c = (1 / (1 + n)) * ((2*n)/n);
                Console.WriteLine(" C{0} = {1}",n,c);
              }
              else
              {
                Console.WriteLine(" Невалидно стойност !");
              }
        }
    }
}

