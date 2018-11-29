
// Напишете програма, която по дадено число N отпечатва числата от 1 до N, разбъркани в случаен ред.

using System;

namespace Zad._16
{
    class Program
    {
        static void Main()
        {
            Console.Write(" Въведи число: ");
            int n = int.Parse(Console.ReadLine());
            Random x = new Random();
            int a, xn;
            int[] arr = new int[n];

              for (int i = 0; i < arr.Length; i++)
              {
                arr[i] = i;
              }

              foreach (int i in arr)
              {
                xn = x.Next(0,n);
                a = arr[i];
                arr[i] = arr[xn];
                arr[xn] = a;
              }

            foreach (int i in arr)
            {
                Console.WriteLine(" " + arr[i]);
            }
        }

    }
    
}
