using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {
        //Arrays
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

        // Immutability - value types asre usually immutable
        [TestMethod]
        public void UppercaseString()
        {
            string name = "andy";
            name = name.ToUpper(); // looks like it changes the underlying string but does not
            // returns a new string fromt the ToUpper method
            // need to capture the results / refeerence to the new string back into original variable
            Assert.AreEqual("ANDY", name);
        }


        // Immutability - DateTimes are immutable. Returns new obj
        [TestMethod]
        public void AddDaysToDateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            date = date.AddDays(1);  // returns a new datetime and returns it from the method. so need to reassign to the variable 

            Assert.AreEqual(2, date.Day);
        }


        // Stays same number as in calling method. vari is only affected in the method. Does not increment in test
        [TestMethod]
        public void ValueTypesPassedByValue()
        {
            int x = 46;
            IncrementNumber(x);
            Assert.AreEqual(46, x);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
        }


        // all 3 varis reference the same object. Names will match
        //[TestMethod]
        //public void ReferenceTypesPassByValue()
        //{
        //    GradeBook book1 = new GradeBook();
        //    GradeBook book2 = book1;

        //    GiveBookAName(book2);
        //    Assert.AreEqual("A Gradebook", book1.Name);

        //}

        //// not used as a test of pass/fail so no attributes and can be private
        //private void GiveBookAName(GradeBook book)
        //{
        //    book.Name = "A Gradebook";
        //}

        // BY REF Ref and out (keywords to change default behavior)
        //Ref turns it into a reference to this variable in th4 calling code
        [TestMethod]
        public void ReferenceTypesPassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookAName(ref book2); // must do explicityly here and in called method (change where book 2 is pointing)
            Assert.AreEqual("A Gradebook", book2.Name); // // would fail if book1…book2 does not influence book1 anymore
            // IS Equal to book2 -passes
        }

        // not used as a test of pass/fail so no attributes and can be private
        private void GiveBookAName(ref GradeBook book)
        {
            book = new GradeBook();
            book.Name = "A Gradebook";
        }

        // Enums
        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Andy";
            string name2 = "andy";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);
        }

        // Value type. Similar tests
        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
        }



        [TestMethod]
        public void GradeBookVariablesHoldAReference()
        {
            // Reference types
            GradeBook g1 = new GradeBook();  // ref type: value in g1 is a pointer
            GradeBook g2 = g1;

            g1 = new GradeBook();
            // 2 varis pointing to the exact sam eobject
            g1.Name = "Andy's Grade book";
            Assert.AreNotEqual(g1.Name, g2.Name);

            //GradeBook g3 = new GradeBook();
            //g3.Name = "test";
            //GradeBook g4 = g3;
            //g4.Name = "g4test overwrite";
            //Assert.AreSame(g3.Name, g4.Name);
        }
    }
}
