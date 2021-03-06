namespace Lecture
{
    public partial class LectureExample
    {
        /*
         13. Write an if/else statement that returns
            "Fizz" if the parameter is 3,
            "Buzz" if the parameter is 5
            and an empty string "" for anything else.
            TOPIC: Conditional Logic
         */
        public string ReturnFizzOrBuzzOrNothing(int number)
        {
            string output = "";

            if (number == 5)
            {
                output = "Buzz";
            }
            else if (number == 3)
            {
                output = "Fizz";
            }

            return output;
        }
    }
}
            
            
            
            
            
            /* one way of answering the question

            if (number == 3) 
            {
                return "Fizz";
            }    
            else if (number ==5) {
                return "Buzz";
            } else
            {
                return "";
            }
            

        }
    }
}
*/