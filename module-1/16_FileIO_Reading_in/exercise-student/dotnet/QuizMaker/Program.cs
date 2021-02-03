using System;
using System.IO;
using System.Collections.Generic;
namespace QuizMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the fully qualified name of the file to read in for quiz questions?");
            //C:\Users\Student\workspace\mbovard-c\module-1\16_FileIO_Reading_in\exercise-student\dotnet\sample-quiz-file.txt
            string filePath = Console.ReadLine();

            try
            {
                using (StreamReader streamReader = File.OpenText(filePath))
                {

                    string stringLine;

                    List<QuizQuestion> questionList = new List<QuizQuestion>();

                    while ((stringLine = streamReader.ReadLine()) != null)
                    {

                        string[] inputLineArray = stringLine.Split("|");

                        QuizQuestion question = new QuizQuestion(inputLineArray[0]);

                        for (int i = 1; i < inputLineArray.Length; i++)
                        {
                            if (inputLineArray[i].Contains("*"))
                            {
                                question.CorrectAnswer = i;
                                question.AddAnswer(inputLineArray[i].Replace("*", ""));
                            }
                            else
                            {
                                question.AddAnswer(inputLineArray[i]);
                            }
                        }

                        questionList.Add(question);
                    }

                    int correctAnswers = 0;

                    for (int i = 0; i < questionList.Count; i++)
                    {
                        Console.WriteLine(questionList[i].Question);
                        for (int j = 0; j < questionList[i].Answers.Count; j++)
                        {
                            Console.WriteLine($"{j + 1}. {questionList[i].Answers[j]}");
                        }
                        Console.WriteLine("Your Answer: ");

                        int theirAnswer = int.Parse(Console.ReadLine());

                        if (theirAnswer == questionList[i].CorrectAnswer)
                        {
                            Console.WriteLine("RIGHT!");
                            correctAnswers += 1;
                        }
                        else
                        {
                            Console.WriteLine("WRONG!");
                        }
                    }

                    Console.WriteLine($"You got {correctAnswers} out of the {questionList.Count} questions asked.");

                }
            }

            catch
            {
                Console.WriteLine("path not found");
                Console.ReadLine();
            }

        }
    }
}
