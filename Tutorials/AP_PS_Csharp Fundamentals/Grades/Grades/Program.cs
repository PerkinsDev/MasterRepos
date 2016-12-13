﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            // cookie cutter - class definition: dont do any actual work but can use to vreate objects
            // stamps out objects from the computer memory
            // must ask for a new instance and use () to invoke the constructor behind the scenes
            // null ref ex- uninitialized variable (grades in gradebook) go back and initialize with the new keyword
            GradeBook book = new GradeBook();
            book.AddGrade(91);
            // must convert a double to float
            book.AddGrade(89.5f);

        }
    }
}
