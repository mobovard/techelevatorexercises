﻿namespace Lecture
{
    public partial class LectureExample
    {
        /*
        15. Now, do it again with a different bool opeation.
        TOPIC: Logical Not
        */
        public string ReturnAdultOrMinorAgain(int number)
        {

            string output = "Adult";

            if ( !(number >= 18) )
            {
                return "Minor";
            }
            else 
            {
                return "Adult";
            }
        }
    }
}
