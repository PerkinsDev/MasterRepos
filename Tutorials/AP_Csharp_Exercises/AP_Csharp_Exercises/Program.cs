using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP_Csharp_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // FROM WEBSITE
            //The exercises below help you practice declaring variables, getting inputs from keyboard, and outputting the results on the console window.

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 1: Write C# code to declare a variable to store the age of a person. Then the output of the program is as an example shown below:
            // You are 20 years old.
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //int age = 0;

            //Console.WriteLine("Enter your age.");
            //age = Convert.ToInt32(Console.ReadLine());
            ////Console.WriteLine("You are " + age + " years old.");
            //Console.WriteLine("You are {0} years old", age);
            //Console.ReadLine();



            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 2: Write C# code to display the asterisk pattern as shown below:
            //*****

            //*****

            //*****

            //*****

            //*****
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            // #1 //
            //string asterisks = "*****";
            //int count = 5;
            //for (int i = 0; i <= count; i++)
            //{
            //    Console.WriteLine(asterisks + Environment.NewLine + Environment.NewLine);
            //}

            //Console.ReadLine();

            // #2 //
            //string asterisks = "*";
            //int count = 5;
            //for (int i = 0; i < count; i++)
            //{
            //    for (int index = 0; index <= 5; index++)
            //    {
            //        Console.Write(asterisks);
            //    }
            //    Console.WriteLine(Environment.NewLine + Environment.NewLine);
            //}
            //Console.ReadLine();


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 3: Write C# code to declare two integer variables, one float variable, and one string variable and assign 10, 12.5, and 
            // "C# programming" to them respectively. Then display their values on the screen.
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //int numberOne = 10;
            //float numberTwo = 12.5f;
            //string text = "C# PROGRAMMING";

            //Console.WriteLine(numberOne);
            //Console.WriteLine(numberTwo);
            //Console.WriteLine(text);

            //Console.ReadLine();


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 4: Write C# code to prompt a user to input his/her name and then the output will be shown as an example below:  Hello - person's name
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Console.WriteLine("What is your name?");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Hello, {0}!", userName);
            //Console.ReadLine();


            // C# operators exercises
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Exercise 1: Write C# code to produce the output shown below:
            //x value        y value        expression result

            //10                       5              x = y + 3                     x = 8

            //10                       5              x = y - 2                      x = 3

            //10                       5              x = y * 5                     x = 25

            //10                       5              x = x / y                      x = 2

            //10                       5              x = x % y                    x = 0
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //int x = 10;
            //int y = 5;

            //Console.WriteLine("x value \t y value \t expression \t result");
            ////Console.WriteLine(x + "\t\t" + y + "\t\t" + "x = y + 3\t "  + "x = " + (x = y + 3));
            //Console.WriteLine("{0}\t\t{1}\t\t{2}\t x = {3}", x, y, "x = y + 3", (x = y + 3));
            ////Console.WriteLine("{0} \t\t {1} \t\t x+=y \t\t x={2}", x, y, x + y);  // someone elses way
            //Console.WriteLine("{0}\t\t{1}\t\t{2}\t x = {3}", x, y, "x = y - 2", (x = y - 2));
            //Console.WriteLine("{0}\t\t{1}\t\t{2}\t x = {3}", x, y, "x = y * 5", (x = y * 5));
            //Console.WriteLine("{0}\t\t{1}\t\t{2}\t x = {3}", x, y, "x = x / y", (x = x / y));
            //Console.WriteLine("{0}\t\t{1}\t\t{2}\t x = {3}", x, y, "x = x % y", (x = x % y));


            //// method from site...wierd formatting. -8 is like a tab (\t)
            ////Console.WriteLine("{0,-8}\t{1,-8}\tx+=y \t x={2,-8}", x, y, x + y);
            ////Console.WriteLine("{0,-8}\t{1,-8}\tx-=y-2 \t x={2,-8}", x, y, x - y + 2);
            ////Console.WriteLine("{0,-8}\t{1,-8}\tx*=y*5 \t x={2,-8}", x, y, x * y * 5);
            ////Console.WriteLine("{0,-8}\t{1,-8}\tx=x/y \t x={2,-8}", x, y, (float)x / (x / y));
            ////Console.WriteLine("{0,-8}\t{1,-8}\tx%=y \t x={2,-8}", x, y, x % y);
            //Console.ReadLine();


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 3: Write C# code to prompt a user to enter an integer value.
            //The value is stored in a variable called a. Then the program will show the output as seen below:
            //The value of a is 10.


            //................................

            //The value of ++a is 11.

            //The value of a is 11.

            //The value of a++ is 11.

            //The value of a is 12.

            //The value of --a is 11.

            //The value of a is 11.

            //The value of a-- is 11.

            //The value of a is 10.
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            //Console.WriteLine("Enter a number:");
            //int a = Convert.ToInt32(Console.ReadLine());
            //string text = "The value of ";
            //Console.WriteLine(text + "a is {0}\n", a);
            //Console.WriteLine("................................\n");
            //Console.WriteLine(text + "++a is {0}", ++a);
            //Console.WriteLine(text + "a is {0}", a);
            //Console.WriteLine(text + "a++ is {0}", a++);
            //Console.WriteLine(text + "a is {0}", a);
            //Console.WriteLine(text + "--a is {0}", --a);
            //Console.WriteLine(text + "a is {0}", a);
            //Console.WriteLine(text + "a-- is {0}", a--);
            //Console.WriteLine(text + "a is {0}", a);

            //Console.ReadLine();


            // C# Conditional statements if else exercises
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 1: Write a C# program that prompts the user to input three integer values and find the greatest value of the three values.
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //int a, b, c;

            //Console.WriteLine("Enter three numbers. Number one:");
            //a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter three numbers. Number two:");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter three numbers. Number three:");
            //c = int.Parse(Console.ReadLine());

            //if (a >= b && a >= c)
            //{
            //    Console.WriteLine("The biggest number is: {0}", a);
            //}
            //else if (b >= a && b >= c)
            //{
            //    Console.WriteLine("The biggest number is: {0}", b);
            //}
            //else if (c >= a && c >= b)
            //{
            //    Console.WriteLine("The biggest number is: {0}", c);

            //}

            //Console.ReadLine();


            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 2: Write a C# program that determines a student’s grade.
            //The program will read three types of scores(quiz score, mid-term score, and final score) and determine the grade based on the following rules:
            //-if the average score = 90 % =>grade = A
            //  -if the average score >= 70 % and < 90 % => grade = B
            //     -if the average score>= 50 % and < 70 % =>grade = C
            //         -if the average score< 50 % =>grade = F
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //double quizScore = 0f;
            //double midTermScore = 0f;
            //double finalScore = 0f;
            //double averageScore = 0f;
            //string grade = "";

            //Console.WriteLine("Enter your quiz score");
            //quizScore = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter your mid Term score");
            //midTermScore = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter your final score");
            //finalScore = Convert.ToDouble(Console.ReadLine());

            //averageScore = (quizScore + midTermScore + finalScore) / 3;

            //if (averageScore >= 50)
            //{
            //    if (averageScore >= 60)
            //    {
            //        grade = "D";

            //        if (averageScore >= 70)
            //        {
            //            grade = "C";

            //            if (averageScore >= 80)
            //            {
            //                grade = "B";

            //                if (averageScore >= 90)
            //                {
            //                    grade = "A";
            //                }
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    grade = "F. ...Terrible";

            //}

            //Console.WriteLine("Your grade is an {0}", grade);
            //Console.ReadLine();





            // C# Conditional statements switch case
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 1: Write a C# program to detect key presses.If the user pressed number keys(from 0 to 9), the program will display the number 
            // that is pressed, otherwise the program will show "Not allowed".
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 2: Write a C# program that allows the user to choose the correct answer of a question.See the example below:
            // What is the correct way to declare a variable to store an integer value in C#?

            //a. int 1x = 10;

            //b. int x = 10;

            //c. float x = 10.0f;

            //d. string x = "10";

            //Choose the answer letter: c

            //Incorrect choice!
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            // C# Loops: for loop exercises
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //Exercise 1: Write C# code to produce the output shown below:
            // *******

            // ******

            // *****

            // ****

            // ***

            // **

            // *
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 2: Write C# code to print the following pattern:
            // 1******

            // 12*****

            // 123****

            // 1234***

            // 12345**

            // 123456*

            // 1234567
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            // C# Loops: while loop exercises
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 1: Write C# program to prompt the user to choose the correct answer from a list of answer choices of a question.
            // What is the command keyword to exit a loop in C#?

            // a. int

            // b. continue

            // c. break

            // d.exit

            // Enter your choice: b

            // Incorrect!

            // Again ? press y to continue:
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 2: Write C# program to print the table of characters that are equivalent to the Ascii codes from 1 to 122.
            // The program will print the 10 characters per line.
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////








            // C# Loops: do while loop exercises
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercise 1:Write C# program to prompt the user to choose the correct answer from a list of answer choices of a question.
            // The user can choose to continue answering the question or stop answering it.See the example below:
            // What is the command keyword to exit a loop in C#?

            // a. int

            // b. continue

            // c. break

            // d.exit

            // Enter your choice: b

            // Incorrect!

            // Again ? press y to continue:
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////




            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // Exercises 2: Write C# program to print the table of characters that are equivalent to the Ascii codes from 1 to 122.
            // The program will print the 10 characters per line.
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        }
    }
}
