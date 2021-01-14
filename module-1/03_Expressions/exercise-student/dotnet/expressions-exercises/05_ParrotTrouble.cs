namespace Exercises
{
    public partial class Exercises
    {
        /*
         We have a loud talking parrot. The "hour" parameter is the current hour time in the range 0..23.
         We are in trouble if the parrot is talking and the hour is before 7 or after 20. Return true if
         we are in trouble.
         ParrotTrouble(true, 6) → true
         ParrotTrouble(true, 7) → false
         ParrotTrouble(false, 6) → false
         */
        public bool ParrotTrouble(bool talking, int hour)
        {
            if (hour <  7 && talking == true)
            {
                return true;
            }
            if (hour > 20 && talking == true)
            {
                return true;
            }

            return false;
        }
    }
}
