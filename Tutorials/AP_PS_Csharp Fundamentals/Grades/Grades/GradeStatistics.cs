using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        // constructor to initialize
        public GradeStatistics()
        {
            HighestGrade = 0;
            LowestGrade = float.MaxValue;

        }

        public float AverageGrade;
        public float HighestGrade;
        public float LowestGrade;

    }
}
