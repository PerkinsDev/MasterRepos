using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_Csharp_Exercises
{
    class ExamplesFromPSInterviewCourse
    {
        // FROM Pluralsite. Job Interview - algorithmic problems
        string title = "i am super Awesome at sports and stuffs";


        public string TitleCase(string title)
        {
            //Split the title string by spaces
           var words = title.Split(' ');
            // Capitalize word[0]
            words[0] = Capitalize(words[0]);
            // Capitalize word[last]
            words[words.Length - 1] = Capitalize(words[words.Length - 1]);

            // for each word  from word[1] to word[last-1]
            for (int i = 1; i < words.Length-1; i++)
            {
                //if ()
                //{
                    
                //}
            }

            return title;
        }
        //Capitalize word method
        public string Capitalize(string word)
        {
            //lowercase the word
            word = Lowercase(word);

            //Capitalize 1st letter
            //word = word.ToUpper().IndexOf(0); //NOPE
            word = char.ToUpper(word[0]) + word.Substring(1);

            return word;
        }

        //lowercase word method
        public string Lowercase(string word)
        {
            //lowercase the word
            //word = word.ToLower();

            return word.ToLower();
        }

    }
}
