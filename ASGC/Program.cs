using static System.Formats.Asn1.AsnWriter;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace ASGC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write a program that includes functions to handle various aspects of grade calculation.

            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();

            //predetermined weights 
            double ass_w = 0.2; //20%
            double quiz_w = 0.3; // 30%
            double final_w = 0.5; //50%

            Console.Write("Enter student assignment scores seperated by commas: ");
            List<double> assignments = new List<double>(Array.ConvertAll(Console.ReadLine().Split(','), double.Parse));

            Console.Write("Enter students quiz scores seperated by commas: ");
            List<double> quizzes = new List<double>(Array.ConvertAll(Console.ReadLine().Split(','), double.Parse));

            Console.Write("Enter student's final exam score: ");
            double finalExam = double.Parse(Console.ReadLine());

            StudentReport(studentName, assignments, quizzes, finalExam, ass_w, quiz_w, final_w);
        }

        public static double Gradecalc(List<double> assignments, List<double> quizzes, double finalExam, double ass_w, double quiz_w, double final_w)
        {
            double avgAssignments = assignments.Count > 0 ? assignments.Sum() / assignments.Count : 0;
            double avgQuizzes = quizzes.Count > 0 ? quizzes.Sum() / quizzes.Count : 0;

            double weightedAverage = (avgAssignments * ass_w) + (avgQuizzes * quiz_w) + (finalExam * final_w);
            return weightedAverage;
        }

        public static string LetterGradeAssignment (double ave)
        {
            if (ave >= 90)
            {
                return "A";
            }
            else if (ave >= 80)
            {
                return "B";
            }
            else if (ave >= 70)
            {
                return "C";
            }
            else if (ave >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }

        public static void StudentReport(string studentName)
        {
            // Sheila
            Console.Write("Student :");
            Console.Write($"Name: {studentName}");

        }
        public static void StudentReport(string studentName, List<double> assignments, List<double> quizzes, double finalExam, double ass_w, double quiz_w, double final_w)
        {
            double weightedAverage = Gradecalc(assignments, quizzes, finalExam, ass_w, quiz_w, final_w); // Fixed method name
            string letterGrade = LetterGradeAssignment(weightedAverage);

            Console.WriteLine("\nStudent Report:");
            Console.WriteLine($"Name: {studentName}");
            Console.WriteLine($"Assignments: {string.Join(", ", assignments)}");

            Console.WriteLine($"Quizzes: {string.Join(", ", quizzes)}");
            Console.WriteLine($"Final Exam: {finalExam}");
            Console.WriteLine($"Weighted Average: {weightedAverage:F2}");
            Console.WriteLine($"Letter Grade: {letterGrade}");
        }
    }
}
