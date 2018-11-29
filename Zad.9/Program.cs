
// Напишете програма, която за дадени цели числа n и x, пресмята сумата:

using System;

namespace Zad._9
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете N: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write(" Въведете X: ");
            int x = int.Parse(Console.ReadLine());

            double facN = 1;
            double powX = 1;
            double sum = 1;

              for (int i = 1; i <= n; i++)
              {
                facN *= i;
                powX *= x;

                sum = sum + (facN / powX);
              }

                Console.WriteLine(" Сумата е {0}",sum);
        }
    }
}

