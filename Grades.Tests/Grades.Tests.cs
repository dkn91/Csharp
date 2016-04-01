using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grades;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void ComputeHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradStatistics result = book.ComputeStats();
            Assert.AreEqual(90, result.HighestGrade);
        }
       
        [TestMethod]
        public void ComputeLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);

            GradStatistics result = book.ComputeStats();
            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputeAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(10);
            book.AddGrade(90);
            book.AddGrade(89.5f);

            GradStatistics result = book.ComputeStats();
            Assert.AreEqual(63.16f, result.AverageGrade, 0.01f); // this test is expected to fail.
        }
        
    }
}
