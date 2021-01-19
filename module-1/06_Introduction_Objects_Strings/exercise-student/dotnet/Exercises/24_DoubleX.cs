﻿namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if the first instance of "x" in the string is immediately followed by another "x".
        DoubleX("axxbb") → true
        DoubleX("axaxax") → false
        DoubleX("xxxxx") → true
        */
        public bool DoubleX(string str)
        {
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'x' && i == str.Length - 1)
                {
                    return false;
                }
                else if (str[i] == 'x' && str[i + 1] == 'x')
                {
                    return true;
                }
                else if (str[i] == 'x')
                {
                    return false;
                }
            }
            return false;
        }
    }
}
