
// Напишете програма, която чете от конзолата числото N и отпечатва сумата на първите N члена от редицата на Фибоначи: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, ...

using System;

namespace Zad._5
{
    class Program
    {
        static void Main()
        {
            int n1 = 0, n2 = 1, n3 = 0;

            Console.Write(" Брой числа: ");
            int br = int.Parse(Console.ReadLine());

            Console.WriteLine(" Редица на Фибоначи: ");
            Console.WriteLine(" 0");
            Console.WriteLine(" 1");

            for (int i = 2; i < br; i++)
            {
                n3 = n1 + n2;
                Console.WriteLine(" {0} ", n3);
                n1 = n2;
                n2 = n3;
                
            }
            n3 += n3;
            Console.WriteLine(" Сумата от N-членовете е: {0}",n3);
        }
    }
}

