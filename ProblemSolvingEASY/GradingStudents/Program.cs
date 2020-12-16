using System;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int[] grades = new int[numberOfStudents];

            for (int i = 0; i < numberOfStudents; i++)
            {
                int grade = int.Parse(Console.ReadLine());

                if (grade % 5 == 0)
                {
                    grades[i] = grade;
                }
                else
                {
                    CheckGrade(grade, grades, i);
                }
            }

            foreach (var grade in grades)
            {
                Console.WriteLine(grade);
            }
        }

        private static void CheckGrade(int grade, int[] grades, int i)
        {
            int initialGrade = grade;
            for (int j = 1; j <= 3; j++)
            {
                grade++;
                if (grade % 5 == 0)
                {
                    grades[i] = grade;
                    break;
                }
            }

            if (grade < 40 || (grade - initialGrade) >= 3)
            {
                grades[i] = initialGrade;
            }
        }
    }
}