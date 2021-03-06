﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);
        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UpperCaseString()
        {
            string name = "jill";
            name = name.ToUpper();

            Assert.AreEqual(name, "JILL");
        }

        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2016, 4, 1);

            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 46;

            IncrementNumber(ref x);

            Assert.AreEqual(47, x);
        }

        private void IncrementNumber(ref int number)
        {
            number += 1;
        }

        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(out book2);
            Assert.AreEqual("A GradeBook", book2.Name);
        }

        private void GiveBookAName(out GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A GradeBook";

        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Jill";
            string name2 = "jill";

            bool result = string.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IntVariablesholdAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;

            Assert.AreNotEqual(x1, x2);

        }

        [TestMethod]
        public void GradeVariablesHoldAReference()
        {
            GradeBook bk1 = new GradeBook();
            GradeBook bk2 = new GradeBook();

            bk1.Name = "Jill's Grade book";

            Assert.AreNotEqual(bk1.Name, bk2.Name);
        }
    }
}
