
// В комбинаториката числата на Каталан (Catalan’s numbers) се изчис­ляват по следната формула, за n ≥ 0. Напи­шете програма, която изчислява n-тото число на Каталан за дадено n.

using System;

namespace Zad._8
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете N: ");
            int n = int.Parse(Console.ReadLine());
             if (n >= 0)
             {
                int n1 = 2 * n;
                int n2 = n + 1;

                for (int i = n1 - 1; i > 0; i--)
                {
                    n1 *= i;
                }
                for (int i = n2 - 1; i > 0; i--)
                {
                    n2 *= i;
                }
                for (int i = n - 1; i > 0; i--)
                {
                    n *= i;
                }
                  int r = n1 / (n2 * n);
                  Console.WriteLine(" N-тото число на Каталан за дадено N e {0}",r);
             }
             else
             {
                Console.WriteLine(" Невалидно число !");
             }
        }
    }
}
