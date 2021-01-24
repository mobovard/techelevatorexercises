namespace Exercises.Classes
{
    public class HomeworkAssignment
    {
        public int EarnedMarks { get; set; }
        public int PossibleMarks { get; private set; }
        public string SubmitterName { get; private set; }
        public string LetterGrade
        {
            get
            {
                double percentageGrade = ((double)EarnedMarks) / ((double)PossibleMarks) * 100;
                if (percentageGrade > 90)
                {
                    return "A";
                }
                if (percentageGrade < 90 && percentageGrade >= 80)
                {
                    return "B";
                }
                if (percentageGrade < 80 && percentageGrade >= 70)
                {
                    return "C";
                }
                if (percentageGrade < 70 && percentageGrade >= 60)
                {
                    return "D";
                }
                else
                {
                    return "F";
                }                
            }
        }

        public HomeworkAssignment(int possibleMarks, string submitterName)
        {
            PossibleMarks = possibleMarks;
            SubmitterName = submitterName;
        }

    }
}
