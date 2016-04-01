using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        //public access modifier will be available to every other class or program calling the class
        //private access modifiers will be only available to the the methods and attributes of that class.
        public GradeBook()
        {
            //Constructor definition using snippet 'ctor'
            grades = new List<float>();
        }

        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        private List<float> grades; //for public attribute definition always use upper case.
    }

}
