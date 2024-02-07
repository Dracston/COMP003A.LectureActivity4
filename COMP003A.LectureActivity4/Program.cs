/*
 * Authour: Logan Jones 
 * Course: COMP-003A
 * Purpose: Lecture Activity 4 Classwork
 * https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
 */

namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("for-loop statement");
            Console.WriteLine("".PadRight(50, '*'));

            //count 0-9
            int limit = 10;// variable limit for loop
            /*The for statement: executes its body while a specified Boolean expression evaluates to true. there are 3 parts in the for loop statement
             * 1. int counter = 0; => loop variable initialization
             * 2. counter < limit; => condition
             * 3. counter++ => iterator
            */
            for (int counter = 0; counter < limit; counter++)
            {
                //this code block will execute every loop
                Console.WriteLine($"\tCurrent counter: {counter}");
            }
            Console.WriteLine("\n"); //New line
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("foreach statement");
            Console.WriteLine("".PadRight(50, '*'));

            //this is a smiple array with 10 items in it. you will learn more about arrays in module 7
            string[] simpleArray = new string[] { "eleifend", "donec", "pretium", "vulputate", "sapien", "nec", "sagittis", "aliquam", "malesuda", "bibendum" };

            //enumerates the elements of a collection and executes its body for each element of the collection
            foreach (var item in simpleArray)
            { Console.WriteLine($"\tCurrent item: {item}"); }

            Console.WriteLine("\n"); //New line
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("do-while statement");
            Console.WriteLine("".PadRight(50, '*'));

            /* 
             * The do statement executes a statement or a block of statements while a specified 
             * Boolean expression evaluates to true. Because that expression is evaluated after
             * each execution of the loop, a do loop executes one or more times. The do statement differs from a while loop, which executes zero or more times.
             */

            int counter2 = 0; //initial counter2 value

            do
            {
                Console.WriteLine($"\tCurrent counter2: {counter2}");
                counter2++; // increment counter 2 by 1
            } while (counter2 < 10); // loop until counter2 is equal to 10 or greater

            Console.WriteLine("\n"); // new line
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("while statement");
            Console.WriteLine("".PadRight(50, '*'));

            /*
             * The while statement executes a statement or a block of statements while a specified
             * Boolean expression evaluates to true. Because that expression is evaluated before
             * each execution of loop, a while loop executes zero or more times. The while statement differs from a do loop, which executes one or more times. 
             */

            int counter3 = 0; // initial counter3 value;
            while (counter3 < 20)
            {
                Console.WriteLine($"\tCurrent counter3 value: {counter3}");
                counter3 += 2; // add 2 to the value of counter3
            }
            Console.WriteLine("\n"); // new line
            Console.WriteLine("".PadRight(50, '*'));
            Console.WriteLine("example for loop program that counter from 1-20 and\r\nchecks if it is odd or even");
            Console.WriteLine("".PadRight(50, '*'));

            //1. loop- variable 'i' is set 1 instead of 0
            //2. looop as long as the lop variable is less than or equal to 20
            //3. increment the loop variable by 1
            for(int i=1; i<=20; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"\t{i}: even");
                }
                else { Console.WriteLine($"\t{i}: odd"); }

            }

        }
    }
}
