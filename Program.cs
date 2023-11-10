using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment_part2
{
    internal class Program
    {
        static void Main(string[] args)
        {



            // Task 1: ArrayList Initialization and Population

            ArrayList studentGrades = new ArrayList
            {
                85,92,78,95,88
            };

            // Task 2: Display and Sum
            Console.WriteLine("Total " + studentGrades.Count+" Grades present in the Student Grade List those are");
            for (int i = 0; i < studentGrades.Count; i++)
            {
                Console.WriteLine(studentGrades[i]);
            }
            int sum = 0;
            for (int i = 0; i < studentGrades.Count; i++)
            {
                sum =sum + (int)studentGrades[i];
            }
            Console.WriteLine($"\nThe sum of all the grades is {sum}.");
            Console.WriteLine("********************************");

            // Task 3: Grade Addition

            studentGrades.Add(90);
            Console.WriteLine("The studentGrades list After adding Grade 90  is:");
            for (int i = 0; i < studentGrades.Count; i++)
            {
                Console.WriteLine(studentGrades[i]);
            }
            Console.WriteLine("********************************");

            // Task 4: Grade Removal

            studentGrades.Remove(78);
            Console.WriteLine("The studentGrades list after removing 78 is:");
            for (int i = 0; i < studentGrades.Count; i++)
            {
                Console.WriteLine(studentGrades[i]);
            }
            Console.WriteLine("********************************");

            // Task 5: Search and update

            int index = studentGrades.IndexOf(95);
            studentGrades[index] = 96;
            Console.WriteLine("The studentGrades list after replacing 95 with 96 is:");
            for (int i = 0; i < studentGrades.Count; i++)
            {
                Console.WriteLine(studentGrades[i]);
            }

            Console.ReadKey();





        }
    }
}
