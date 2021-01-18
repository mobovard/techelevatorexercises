using System;

namespace ToDo_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To do List!");
            Console.WriteLine("enter some things you would like to do");
            Console.WriteLine("Enter 'done' when done");




            bool running = true;
            string[] todoArray= new string[1];

            while (running)
            {
                string userTyped;
                userTyped = Console.ReadLine();

                if (userTyped == "done")
                {
                    running = false;
                }

                todoArray[0] = userTyped;
            }
            
            
            /* ask the user to enter a single item
             * keep asking until they type 'n'
             * display the list 1,2,3 ect
            */
        }
    }
}
