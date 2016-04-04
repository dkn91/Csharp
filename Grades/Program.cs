using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            GradeBook bk1 = new GradeBook();
            GradeBook bk2 = bk1;

            bk1.Name = "Jill's Grade book";
            Console.WriteLine(bk2.Name);
            Console.ReadLine();
            */
            
            GradeBook book = new GradeBook();
            book.NameChanged = new NameChangedDelegate(OnNameChanged);
            book.NameChanged += new NameChangedDelegate(OnNameChanged2);

            book.Name = "Jills gradebook";
            book.Name = "Jane's gradebook";
            book.AddGrade(99);
            book.AddGrade(99.5f);
            book.AddGrade(9.5f);
            //we can create a new Gradbook variable assigned to the old object.
            //only the refe to the memory gets assigned and the new variable and old are now pointing to the same memory location.
            //GradeBook bk2 = book;
            //bk2.AddGrade(99.1f);

            GradStatistics stats = book.ComputeStats();
            Console.WriteLine(book.Name);
            WriteResult("HighestGrade", (int)stats.HighestGrade);
            WriteResult("Lowest",stats.LowestGrade);
            WriteResult("Average", stats.AverageGrade);
            Console.ReadLine();
            
        }

        static void OnNameChanged(string existingName, string newName)
        {
            Console.WriteLine($"Grade book changing name from {existingName} to {newName}");
        }

        static void OnNameChanged2(string existingName, string newName)
        {
            Console.WriteLine("***");
        }
        static void WriteResult(string description, int result)
        {
            Console.WriteLine(description + ": " + result);
        }

        static void WriteResult(string description, float result)
        {
            //Console.WriteLine("{0}: {1:C}", description, result);
            Console.WriteLine($"{description}: {result}");
        }
    }
}
