using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            GradeBook book = new GradeBook();
            book.AddGrade(99);
            book.AddGrade(99.5f);
            book.AddGrade(9.5f);
            //we can create a new Gradbook variable assigned to the old object.
            //only the refe to the memory gets assigned and the new variable and old are now pointing to the same memory location.
            //GradeBook bk2 = book;
            //bk2.AddGrade(99.1f);

            GradStatistics stats = book.ComputeStats();
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            Console.WriteLine(stats.AverageGrade);
            Console.ReadLine();
        }
    }


}
