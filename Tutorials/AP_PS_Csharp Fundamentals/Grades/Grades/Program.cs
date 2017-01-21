using System;
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
            
           
            
            GradeBook book = new GradeBook();

          
            book.AddGrade(91);
            // must convert a double to float
            book.AddGrade(89.5f);
            book.AddGrade(75);


            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);  // explicit conversion. type coertion, typecast
            WriteResult("Lowest", stats.LowestGrade);
            WriteResult("Grade", stats.LetterGrade);
        } 
       

        static void WriteResult(string description, float result)
        {
            //Console.WriteLine(description + ": " + result);
            // the {} are placeholders. The parameters passed in are packed into an array 
            // and at runtime the compiler looks in array at specified element
            // Console.WriteLine("{0}: {1:F2}", description, result);
            // New in C# 6
            // String Interpolation instead of formatting strings
            Console.WriteLine($"{description}: {result:F2}");

        }

        // Overload to accept string to output letter grade
        static void WriteResult(string description, string result)
        {
           
            // String Interpolation instead of formatting strings
            Console.WriteLine($"{description}: {result}");

        }

        /****************************************************************************/
        /* BEGIN TUTORIAL CODE ARCHIVE                                              */
        /****************************************************************************/

        //Console.WriteLine(g2.Name);  // results in g1's name
        // From referencing assemblies outside of the project template
        //SpeechSynthesizer synth = new SpeechSynthesizer();
        //synth.Speak("Hello! This is the grade book program. thwekjrthwerfhouishvjvnskdjfhoeuirdfjnsdfuseuilfh");

        // cookie cutter - class definition: dont do any actual work but can use to vreate objects
        // stamps out objects from the computer memory
        // must ask for a new instance and use () to invoke the constructor behind the scenes
        // null ref ex- uninitialized variable (grades in gradebook) go back and initialize with the new keyword
        // ctr + f10 or right click to run to cursor - quixk debug with no break point


        ////// Delegate calls the method below whent the name property is changed
        ////book.NameChanged += new NameChangedDelegate(OnNameChanged);
        //////can call multi methods. += ensures both are called instead of just reassigning
        ////book.NameChanged += new NameChangedDelegate(OnNameChanged2);
        ////book.NameChanged += new NameChangedDelegate(OnNameChanged2);

        ////Simpler way for C#: auto creates delegate instance for you
        //// Delegate calls the method below whent the name property is changed
        //book.NameChanged += OnNameChanged;
        //    //can call multi methods. += ensures both are called instead of just reassigning



        //    book.Name = "Andy's Grade Book";   // public field. will redo as a property
        //    book.Name = "Grade Book";
        //    // book.Name = null;  handled by the name props set method

        // Console.WriteLine(book.Name);

        //// Event Handler
        //static void OnNameChanged(object sender, NameChangedEventArgs args)
        //{
        //    Console.WriteLine($"Gradebook changing name from {args.ExistingName} to {args.NewName}.");
        //}



        //// c# compiler knows which method to call
        //static void WriteResult(string description, int result)
        //{
        //    Console.WriteLine(description + ": " + result);
        //}
    }
}
