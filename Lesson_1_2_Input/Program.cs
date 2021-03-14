using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1_2_Input
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();

            // Call the method you're currently working on here.
            program.EnterDetails();
        }

        /// <summary>
        /// Task: Create a program that prompts:
        ///     'Please enter your name: {name}
        ///      Please enter your age: {age}
        ///     
        ///      Your name and age is: {name}, {age}.'
        /// 
        /// Use string interpolation to output the name and age.
        /// 
        /// Object: To teach reading inputs to a variable.
        /// </summary>
        public void EnterDetails()
        {
            Console.Write("Please enter your name: ");
            var name = Console.ReadLine();

            Console.Write("Please enter your age: ");
            var age = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine($"Your name and age is: {name}, {age}.");
        }
    }
}
