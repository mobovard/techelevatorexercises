﻿namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 int values, return true if either of them is in the range 10..20 inclusive.
         In1020(12, 99) → true
         In1020(21, 12) → true
         In1020(8, 99) → false
         */
        public bool In1020(int a, int b)
        {
            bool output = false;

            if ((a >= 10 && a <= 20) || (b >= 10 && b <= 20))
            {
                output = true;
            }    
            return output;
        }
    }
}
