using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that keeps the information about students and their grades. 
            //You will receive n pair of rows.First, you will receive the student's name, after that, you will receive his grade.
            //Check if the student already exists and if not, add him. Keep track of all grades for each student.

            //We receive the number of grades that will follow and innitiate our dictionary.
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentGrades = new Dictionary<string, List<double>>();    

            //We add the students and their grades in our dictionary
            for (int i = 0; i < n ; i++)
            {
                string currentStudent = Console.ReadLine();
                double currentGrade = double.Parse(Console.ReadLine());

                if (studentGrades.ContainsKey(currentStudent))
                {
                    studentGrades[currentStudent].Add(currentGrade);
                }

                else
                {
                    studentGrades.Add(currentStudent, new List<double>());
                    studentGrades[currentStudent].Add(currentGrade);
                }
            }

            //We calculate each students average grade.
            foreach (var student in studentGrades)
            {
                double totalGrades = student.Value.Sum();
                int numOfGrades = student.Value.Count();
                double averageGrade = totalGrades / numOfGrades;
                //We check if the average grade is above 4.50 and print if it is.
                if (averageGrade>=4.50)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                }
            }
        }
    }
}
