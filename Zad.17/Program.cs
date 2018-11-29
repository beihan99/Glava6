
// Напишете програма, която за дадени две числа, намира най-големия им общ делител.

using System;

namespace Zad._17
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведи I-во число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write(" Въведи II-ро число: ");
            int b = int.Parse(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }

            if (a == 0)
            {
                Console.WriteLine(" Най-големия им общ делител: "+b);
            }
            else
            {
                Console.WriteLine(" Най-големия им общ делител: " + a);
            }
        }
    }
}
