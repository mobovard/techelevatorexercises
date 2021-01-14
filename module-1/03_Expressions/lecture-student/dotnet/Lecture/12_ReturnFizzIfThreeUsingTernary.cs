namespace Lecture
{
    public partial class LectureExample
    {
        /*
        12. Now write the above using the Ternary operator ?:
        */
        public string ReturnFizzIfThreeUsingTernary(int number)
        {
            string output = (number == 3) ? "Fizz" : "";
            return output;
        }
    }
}
