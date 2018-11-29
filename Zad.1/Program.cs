
// Напишете програма, която отпечатва на конзолата числата от 1 до N. Числото N трябва да се чете от стандартния вход.

using System; 

namespace Zad._1
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Брой числа: ");
            int br = int.Parse(Console.ReadLine());
              for(int i =1; i<=br; i++)
               {
                Console.WriteLine(" {0}",i);
               }
        }
    }
}
