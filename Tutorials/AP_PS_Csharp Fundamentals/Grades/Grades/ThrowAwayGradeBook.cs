using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    // Can always take a derived type and assign it to a variable of the parent type.
    public class ThrowAwayGradeBook : GradeBook
    {
        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("ThrowAwayGradeBook::ComputeStatistics");


            float lowest = float.MaxValue;
            foreach (float grade in grades)
            {
                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest);

            return base.ComputeStatistics();
        }
    }
}
