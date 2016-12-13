using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        // members of the class - 2 types
        // 1.hold state or data - grades
        // 2.behavior - do work - methods - are verbs
        public void AddGrade(float grade) // grade param (can think ps as a variable and use ant where inside the curly braces)is scoped to this method
        {
            grades.Add(grade); 
        }

        // grades is a field - member that holds state. List is from the collection class. list of floats to hold grades
        List<float> grades = new List<float>(); // generic type syntax <>.

    }
}
