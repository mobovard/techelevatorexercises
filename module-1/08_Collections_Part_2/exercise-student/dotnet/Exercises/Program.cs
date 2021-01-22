using System;
using System.Collections.Generic;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercises exercises = new Exercises();

            Console.WriteLine("Hello World!");

            Dictionary<string, int> expected = new Dictionary<string, int>()
            {
                {"Peter", 37500 },
                {"Paul", 75000 },
                {"PeterPaulPartnership", 37500 }
            };
            Dictionary<string, int> actual = exercises.PeterPaulPartnership(new Dictionary<string, int>()
            {
                {"Peter", 50000 },
                {"Paul", 100000 }
            });

            Console.WriteLine($"Peter : {actual["Peter"]}  Paul : {actual["Paul"]} PeterPaulPartnership : {actual["PeterPaulPartnership"]}");
        }
    }
}
