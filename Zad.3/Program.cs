
// Напишете програма, която чете от конзолата поредица от цели числа и отпечатва най-малкото и най-голямото от тях.

using System;

namespace Zad._3
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Брой числа: ");
            int br = int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;

              for (int i = 0; i < br; i++)
              {
                Console.Write(" Число: ");
                int n = int.Parse(Console.ReadLine());
                  if (n > max)
                  {
                    max = n;
                  }
                if (min > n)
                {
                    min = n;
                }
             }
            Console.WriteLine(" Най-малкото число е: {0}",min);
            Console.WriteLine(" Най-голямото число е: {0}",max);

        }
    }
}
