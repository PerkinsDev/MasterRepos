using System;
using System.Collections.Generic;
using System.IO;
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
            _name = "Empty";
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

        // Textwriter is an abstract class that writes character data to whatever output you specify
        public void WriteGrades(TextWriter destination) //Escape character to use a C# keyword i.e. out, class. not reccomended
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
        public void AddGrade(float grade) // grade param (can think ps as a variable and use ant where inside the curly braces)is scoped to this method
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

        public string Name
        {
            get
            {
                // when someone wants to read the name property - return private field
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }

                // Delegates
                // if we know the name is changing (do not match). then want to be able to invoke some arbitrary code
                if (_name != value && NameChanged != null)
                {
                    // Instance the NAmeChangedEventArgs class to set names to the string params of the method
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;
                    // Invoke delegate if name has chenged
                    // use the this keyword to pass along the object you are working inside of
                    NameChanged(this, args);
                }

                // if value is not null or empty, then will I assign this value into the _name field. otherwise do nothing
                _name = value;
            }

        }

        // now have a public member that other areas of app can walk up to and assign to thos delegate and gov it the code that needs to be invoked somewhere in the outside world
        public event NameChangedDelegate NameChanged;

        private string _name;


        // public field...will redo as a property
        //public string Name;

        // grades is a field - member that holds state. List is from the collection class. list of floats to hold grades
        // private set explicitly for readability - private is default access mod.  do because you want to encapsulate / protect
        private List<float> grades;             // = new List<float>(); // generic type syntax <>.

    }
}
