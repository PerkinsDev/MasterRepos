using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests.Types
{
    [TestClass]
    public class ReferenceTypeTests
    {

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
