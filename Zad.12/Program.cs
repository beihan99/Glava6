
// Напишете програма, която преобразува дадено число от десетична в двоична бройна система.

using System;

namespace Zad._12
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведете число: ");
            int n = int.Parse(Console.ReadLine());
            string m = Convert.ToString(n,2);
            Console.WriteLine(" {0}(10) ---> {1}(2)",n,m);
        }
    }
}
