
// Напишете програма, която преобразува дадено число от десетична в шестнайсетична бройна система.

using System;

namespace Zad._14
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            string m = Convert.ToString(n, 16);
            Console.WriteLine(" {0}(10) ---> {1}(16)", n, m);
        }           
    }
}

