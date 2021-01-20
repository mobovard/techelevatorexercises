namespace Exercises
{
    public partial class StringExercises
    {
        /*
        Given a string, return a string made of the chars at indexes 0,1, 4,5, 8,9 ... so "kittens" yields "kien".
        AltPairs("kitten") → "kien"
        AltPairs("Chocolate") → "Chole"
        AltPairs("CodingHorror") → "Congrr"
        */
        public string AltPairs(string str)
        {
            string firstTwo = "";
            string middleTwo = "";
            string lastTwo = "";
            string lastOne = "";
            string middleOne = "";

            if (str.Length == 0)
            {
                return "";
            }
            if (str.Length == 1)
            {
                return str.Substring(0, 1);
            }
            if (str.Length == 5)
            {
                firstTwo = str.Substring(0, 2);
                middleOne = str.Substring(4, 1);
                return firstTwo + middleOne;
            }
            if (str.Length == 9)
            {
                firstTwo = str.Substring(0, 2);
                middleTwo = str.Substring(4, 2);
                lastOne = str.Substring(8, 1);
                return firstTwo + middleTwo + lastOne;
            }
            if (str.Length > 1 && str.Length < 6)
            {
                firstTwo = str.Substring(0, 2);
                return firstTwo;
            }

            if (str.Length > 5 && str.Length < 10)
            {
                firstTwo = str.Substring(0, 2);
                middleTwo = str.Substring(4, 2);
                return firstTwo + middleTwo;
            }
            
            else
            {
                firstTwo = str.Substring(0, 2);
                middleTwo = str.Substring(4, 2);
                lastTwo = str.Substring(8, 2);
                return firstTwo + middleTwo + lastTwo;
            }
          
        }
    }
}
