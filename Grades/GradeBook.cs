using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        //public access modifier will be available to every other class or program calling the class
        //private access modifiers will be only available to the the methods and attributes of that class.
        public GradeBook()
        {
            //Constructor definition using snippet 'ctor'
            grades = new List<float>();
        }

        public GradStatistics ComputeStats()
        {
            GradStatistics stats = new GradStatistics();
            
            float sum = 0;
            foreach(float grade in grades)
            {
                sum += grade;
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public string Name //all fields/properties that are exposed with public access modifier should be defined using get/set
        {
            get
            {
                return _name;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Name cannot be overwritten");
                }
            }
        }

        private string _name;
        private List<float> grades; //for public attribute definition always use upper case.
    }

}
