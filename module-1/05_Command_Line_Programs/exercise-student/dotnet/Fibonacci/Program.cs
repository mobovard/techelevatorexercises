using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the Fibonacci number:");

            string inputString = Console.ReadLine();
            int inputAsInt = int.Parse(inputString);

            string fibString = "0";
            int currentFib = 1;
            int lastFib = 0;
            int nextFib = 0;
            while (inputAsInt > currentFib)
            {
                fibString = fibString + ", " + currentFib;
                nextFib = currentFib + lastFib;
                lastFib = currentFib;
                currentFib = nextFib;
            }

            Console.WriteLine(fibString);

           
        }
    }
}
