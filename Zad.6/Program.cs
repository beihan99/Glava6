
// Напишете програма, която пресмята N!/K! за дадени N и K (1<K<N).

using System;

namespace Zad._6
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Числото N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(" Числото K: ");
            int k = int.Parse(Console.ReadLine());

              for (int i = n - 1; i > 0; i--)
              {
                n *= i;
              }

              for (int i = k - 1; i > 0; i--)
              {
                k *= i;
              }
           Console.WriteLine(" N!/K! = {0}", n /= k);
        }
    }
}

