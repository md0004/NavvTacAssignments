using System;
using System.Net.NetworkInformation;
namespace Assignment3
{
    class StudentPerformance
    {
        static void Main(string[] args)
        {

            // Store these marks in a list and display average of student, max marks, minumum marks:
            // 0, 98, 67, 9, 45, 44, 23, 2
            // Don't use built in methods


            Console.WriteLine("Question No. 1");
            Console.WriteLine();

            List<int> StudentMarks = new List<int>
            {
                0, 98, 67, 9, 45, 44, 23, 2
            };

            int MaximumMarks = 0;
            int MinimumMarks = 0;
            int AverageOfStudentMarks = 0;

            for(int start = 0; start < StudentMarks.Count; start++)
            {
                AverageOfStudentMarks = AverageOfStudentMarks + StudentMarks[start];

                if (MaximumMarks < StudentMarks[start])
                {
                    MaximumMarks = StudentMarks[start];
                }

                if(MinimumMarks > StudentMarks[start])
                {
                    MinimumMarks = StudentMarks[start];
                }
            }

            AverageOfStudentMarks = AverageOfStudentMarks / StudentMarks.Count; 

            Console.WriteLine(value: $"Maximum Marks are: {MaximumMarks}");    // Maximum Marks
            Console.WriteLine(value: $"Minimum Marks are: {MinimumMarks}");    // Minimum Marks
            Console.WriteLine(value: $"Average Marks of students are: {AverageOfStudentMarks}");   // Student's Average Marks
            Console.WriteLine();




            //Using nested for loops print these patterns

            //*
            //**
            //***

            Console.WriteLine("Question No. 2");
            Console.WriteLine();

            for (int i = 1; i < 4; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //321
            //32
            //1

            Console.WriteLine("Question No. 3");
            Console.WriteLine();

            for (int i = 3; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();


        }
    }
}
