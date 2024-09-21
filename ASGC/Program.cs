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

            Console.Write("enter students quiz scores: ");
            double set_assignment = double.Parse(Console.ReadLine());

            StudentReport(studentName);
        }

        public static double Gradecalc (double ass_w, double quiz_w, double final_w)
        {
            // Sheila 
            // paname nalang ng total weighted grade ng ave para sa next funtion. tenkss.
        }

        public static string LetterGradeAssignment (ave)
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
    }
}
