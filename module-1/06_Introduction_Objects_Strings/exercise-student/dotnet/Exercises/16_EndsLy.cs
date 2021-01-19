namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return true if it ends in "ly".
        EndsLy("oddly") → true
        EndsLy("y") → false
        EndsLy("oddy") → false
        */
        public bool EndsLy(string str)
        {
            int length = str.Length;
            bool endsLy = false;
            if (length >= 2)
            {
                string lastTwo = str.Substring(str.Length - 2, 2);
                endsLy = lastTwo.Equals("ly");                
            }
            else
            {
                endsLy = false;
            }
            return endsLy;
        }
    }
}
