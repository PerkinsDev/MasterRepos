using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook : GradeTracker
    {

        // constructor - explicit access to initialization -  snippets is ctor + tab + tab            
        public GradeBook()
        {
            _name = "Empty";
            grades = new List<float>();  // can do as a field as below or in the traditional ctor - same except here you can pass parameters in
        }


        public override GradeStatistics ComputeStatistics()
        {
            Console.WriteLine("GradeBook::ComputeStatistics");

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

        // Textwriter is an abstract class that writes character data to whatever output you specify
        public override void WriteGrades(TextWriter destination) //Escape character to use a C# keyword i.e. out, class. not reccomended
        {
            for (int i = 0; i < grades.Count; i++) // often you loop over a collection which has a count prop or an array which has a length prop
            {
                destination.WriteLine(grades[i]);
            }

            // reverse order
            for (int i = grades.Count; i > 0; i--) // often you loop over a collection which has a count prop or an array which has a length prop
            {
                destination.WriteLine(grades[i - 1]);
            }
        }

        // members of the class - 2 types
        // 1.hold state or data - grades
        // 2.behavior - do work - methods - are verbs
        public override void AddGrade(float grade) // grade param (can think ps as a variable and use ant where inside the curly braces)is scoped to this method
        {
            grades.Add(grade);
        }


        // Auto Implemented properties will not protect against null or empty values / strings
        // Need to add some logic
        //Since not auto - need to make a private field(which was happening behind the scenes
        //public string Name
        //{
        //    get; set;
        //}


        // public field...will redo as a property
        //public string Name;

        // grades is a field - member that holds state. List is from the collection class. list of floats to hold grades
        // private set explicitly for readability - private is default access mod.  do because you want to encapsulate / protect
        // Setting as protected allows access for current class and DERIVED class
        protected List<float> grades;             // = new List<float>(); // generic type syntax <>.

    }
}
