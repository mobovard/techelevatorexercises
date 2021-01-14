namespace Lecture
{
    public partial class LectureProblem
    {
        /*
        5a. Sometimes we don't know how large the array is that we're given.
            Return the last element of the array from the parameters
            TOPIC: Accessing Array Elements
        */
        public int ReturnLastElementOfParam(int[] passedInArray)
        {
            int arrayLength = passedInArray.Length;

            int lastElement = passedInArray[arrayLength - 1];

            return lastElement;
        }

        /*
        5b. Return the second to last element of the array from the parameters
            TOPIC: Accessing Array Elements
        */
        public int ReturnSecondToLastElementOfParam(int[] passedInArray)
        {
            int arrayLength = passedInArray.Length - 2;
            int lastElement = passedInArray[arrayLength];
                //need to add the rest of this exercise and 5c as well from lecture video
            return 1;
        }

        /*
        5c. Set the last element in the array to 100.
            TOPIC: Setting Array Elements
        */
        public void SetLastElement(int[] passedInArray)
        {
            return;
        }
    }
}
