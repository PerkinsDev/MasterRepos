using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {

        // constructor - explicit access to initialization -  snippets is ctor + tab + tab            
        public GradeBook()
        {
            grades = new List<float>();  // can do as a field as below or in the traditional ctor - same except here you can pass parameters in
        }


        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            // loops over the grades in the grades collection and keeps track of the highest and lowest and computes sum
            foreach (float grade in grades)
            {
                // Math.max static member) pass in 2 numbers and it will return the highest of the 2
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }
            stats.AverageGrade = sum / grades.Count;
            return stats;
        }

        // members of the class - 2 types
        // 1.hold state or data - grades
        // 2.behavior - do work - methods - are verbs
        public void AddGrade(float grade) // grade param (can think ps as a variable and use ant where inside the curly braces)is scoped to this method
        {
            grades.Add(grade); 
        }

        public string Name;
    
        // grades is a field - member that holds state. List is from the collection class. list of floats to hold grades
        // private set explicitly for readability - private is default access mod.  do because you want to encapsulate / protect
        private List<float> grades;             // = new List<float>(); // generic type syntax <>.

    }
}
