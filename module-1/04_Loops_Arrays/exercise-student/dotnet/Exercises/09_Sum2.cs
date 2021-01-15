namespace Exercises
{
    public partial class Exercises
    {
        /*
         Given an array of ints, return the sum of the first 2 elements in the array. If the array length
          is less than 2, just sum up the elements that exist, returning 0 if the array is length 0.
         Sum2([1, 2, 3]) → 3
         Sum2([1, 1]) → 2
         Sum2([1, 1, 1, 1]) → 2
         */
        public int Sum2(int[] nums)
        {
           int numsArrayLength = nums.Length;

            int output = 0;
           
            if (numsArrayLength == 0)
            {
                output = 0;
            }
            else if (numsArrayLength < 2)
            {
              
                {
                    output += nums[0];
                }
            }
            else
            {
                
                {
                    output = nums[0] + nums[1];
                }
            }
            return output;
        }
    }
}
