
// Напишете програма, която пресмята с колко нули завършва факториелът на дадено число.

using System;

namespace Zad._11
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число N: ");
            int n = int.Parse(Console.ReadLine());
            int z = 0;
             for (int i = n - 1; i > 0; i--)
             {
                n *= i;
             }
               Console.Write(" N! = {0} ", n);
             do
             {
                n /= 10;
                z++;
             } while (n % 10 == 0);

              Console.WriteLine("и завършва с {0} нули.", z);
        }
    }
}
