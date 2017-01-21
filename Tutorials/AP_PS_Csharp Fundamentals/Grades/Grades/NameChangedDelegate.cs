using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    // this matches the method we can point this de;egate to in th GradeBook _name property check
    // broke out string existingName, string newName params to a custom NameChangedEventArgs class
    // by convention the delegate will now hold sender and args
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);
   
}
