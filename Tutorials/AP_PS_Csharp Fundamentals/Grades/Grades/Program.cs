﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Speech.Synthesis;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine(g2.Name);  // results in g1's name



            // From referencing assemblies outside of the project template
            //SpeechSynthesizer synth = new SpeechSynthesizer();
            //synth.Speak("Hello! This is the grade book program. thwekjrthwerfhouishvjvnskdjfhoeuirdfjnsdfuseuilfh");

            // cookie cutter - class definition: dont do any actual work but can use to vreate objects
            // stamps out objects from the computer memory
            // must ask for a new instance and use () to invoke the constructor behind the scenes
            // null ref ex- uninitialized variable (grades in gradebook) go back and initialize with the new keyword
            
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            // must convert a double to float
            book.AddGrade(89.5f);
            book.AddGrade(75);


            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            


        }  // ctr + f10 or right click to run to cursor - quixk debug with no break point
    }
}
