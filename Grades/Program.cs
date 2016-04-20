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
            //book.NameChanged = OnNameChanged;
            //book.NameChanged += OnNameChanged2;

            //book.Name = "Jills gradebook";
            //book.Name = "Jane's gradebook";
            book.AddGrade(99);
            book.AddGrade(99.5f);
            book.AddGrade(99.5f);
            //we can create a new Gradbook variable assigned to the old object.
            //only the refe to the memory gets assigned and the new variable and old are now pointing to the same memory location.
            //GradeBook bk2 = book;
            //bk2.AddGrade(99.1f);

            GradStatistics stats = book.ComputeStats();
            //Console.WriteLine(book.Name);
            WriteResult("HighestGrade", stats.HighestGrade);
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Average", stats.AverageGrade);
            WriteResult(stats.Description, stats.LetterGrade);
            Console.ReadLine();
            
        }

        static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Grade book changing name from {args.ExistingName} to {args.NewName}");
        }

        static void OnNameChanged2(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine("***");
        }
        static void WriteResult(string description, string result)
        {
            Console.WriteLine(description + ": " + result);
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
