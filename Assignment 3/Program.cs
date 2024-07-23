using System;
namespace Assignment3
{
    class StudentPerformance
    {
        static void Main(string[] args)
        {
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

        }
    }
}