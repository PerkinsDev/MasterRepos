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
    public class GradeBookTests  // must be public with multi projects for task runner
    {
        [TestMethod]
        public void ComputesHighestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(90, result.HighestGrade);
        }

        [TestMethod]
        public void ComputesLowestGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(90);
            book.AddGrade(10);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(10, result.LowestGrade);
        }

        [TestMethod]
        public void ComputesAverageGrade()
        {
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);

            GradeStatistics result = book.ComputeStatistics();

            Assert.AreEqual(85.16, result.AverageGrade, 0.01);
            // by Calculator 85.16666666666667 is average but will throw error. Very difficult to work wit floating point numbers
            // can use the Delta option (how off can it vary by) which is a third parameter to pass into this Assert
        }
    }
}
