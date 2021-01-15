namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given 2 arrays of ints, a and b, return true if they have the same first element or they have
         the same last element. Both arrays will be length 1 or more.
         CommonEnd([1, 2, 3], [7, 3]) → true
         CommonEnd([1, 2, 3], [7, 3, 2]) → false
         CommonEnd([1, 2, 3], [1, 3]) → true
         */
        public bool CommonEnd(int[] a, int[] b)
        {
            int aFirstElement = a[0];
            int bFirstElement = b[0];
            int aLengthIndex = a.Length - 1;
            int aLastElement = a[aLengthIndex];
            int bLengthIndex = b.Length - 1;
            int bLastElement = b[bLengthIndex];

            bool areEqual = false;
            if ((aFirstElement == bFirstElement) || (aLastElement == bLastElement))
            {
                areEqual = true;
            }

            return areEqual;
        }
    }
}
