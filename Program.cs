using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
                
                string[] students = new string[5] { "swapna", "neelima", "Kalpna", "Devi", "Anu" };
                int[] marks = new int[5] { 85, 92, 78, 95, 88 };

                
                Console.WriteLine("Student Details:");
                for (int i = 0; i < students.Length; i++)
                {
                    Console.WriteLine($"Student: {students[i]}, Marks: {marks[i]}");
                }

               
                int totalMarks = 0;
                for (int i = 0; i < marks.Length; i++)
                {
                    totalMarks += marks[i];
                }
            double averageMarks = (double)totalMarks / marks.Length;
            Console.WriteLine($"Average Marks: {averageMarks:F2}");
            Console.ReadKey();

        }
        }
}
