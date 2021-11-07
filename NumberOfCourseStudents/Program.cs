using System;
using System.Collections.Generic;

namespace NumberOfStudentsInCourses
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int StudentEnrollment = int.Parse(Console.ReadLine());
                courseA.Add(StudentEnrollment);
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int StudentEnrollment = int.Parse(Console.ReadLine());
                courseB.Add(StudentEnrollment);
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int StudentEnrollment = int.Parse(Console.ReadLine());
                courseC.Add(StudentEnrollment);
            }

            HashSet<int> allStudents = new HashSet<int>(courseA);
            allStudents.UnionWith(courseB);
            allStudents.UnionWith(courseC);

            Console.WriteLine();
            Console.WriteLine("Total students: " + allStudents.Count);
        }
    }
}
