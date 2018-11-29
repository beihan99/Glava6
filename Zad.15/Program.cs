
// Напишете програма, която преобразува дадено число от шестнайсе­тична в десетична бройна система.

using System;

namespace Zad._15
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            string n = Console.ReadLine();
            int m = Convert.ToInt32(n, 16);
            Console.WriteLine(" {0}(16) ---> {1}(10)", n, m);
        }
    }
}

