using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public abstract class GradeTracker
    {
        public abstract void AddGrade(float grade);
        public abstract GradeStatistics ComputeStatistics();
        public abstract void WriteGrades(TextWriter destination);
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

        protected string _name;



    }
}
