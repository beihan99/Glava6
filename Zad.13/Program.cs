
// Напишете програма, която преобразува дадено число от двоична в десетична бройна система.

using System;

namespace Zad._13
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            string n = Console.ReadLine();
            int m = Convert.ToInt32(n, 2);
            Console.WriteLine(" {0}(2) ---> {1}(10)", n, m);
        }

    }
}

