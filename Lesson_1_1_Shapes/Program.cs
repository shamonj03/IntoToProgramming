using System;

namespace Lesson_1_1_Shapes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var program = new Program();

            // Call the method you're currently working on here.
            program.HardCoded_DrawTriangle();
        }

        /// <summary>
        /// Task: Print a 4x4 square using '*' for the character.
        /// Objective: To teach the WriteLine method.
        /// </summary>
        public void HardCoded_DrawSquare()
        {
            Console.WriteLine("****");
            Console.WriteLine("****");
            Console.WriteLine("****");
            Console.WriteLine("****");
        }

        /// <summary>
        /// Task: Draw 4x4 a triangle using '*' for the character.
        /// Objective: To teach the WriteLine method.
        /// </summary>
        public void HardCoded_DrawTriangle()
        {
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
        }

        /// <summary>
        /// Task: Print a nxn square using '*' for the character.
        /// Objective: To teach a nested for loop. Think of it as drawing a grid.
        /// </summary>
        /// <param name="n">The number of rows/columns.</param>
        public void Dynamic_DrawSquare(int n)
        {

            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Task: Print a nxn triangle using '*' for the character.
        /// Objective: To teach a nested for loop with a small tweak.
        /// </summary>
        /// <param name="n">The number of rows/columns.</param>
        public void Dynamic_DrawTriangle(int n)
        {
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x <= y; x++)
                    Console.Write("*");

                Console.WriteLine();
            }
        }

        /// <summary>
        /// Task: Print a nxn square using '*' for the character.
        /// Objective: To teach if statements as well as the modulus operator
        /// </summary>
        /// <param name="n">The number of rows/columns.</param>
        public void Dynamic_Alternating_DrawSquare(int n)
        {
            // Print a nxn square using that alternates 'x' and 'o' for the characters.
            for (int y = 0; y < n; y++)
            {
                for (int x = 0; x < n; x++)
                {
                    if((x % 2) == 0)
                        Console.Write("x");
                    else
                        Console.Write("o");
                }

                Console.WriteLine();
            }
        }
    }
}
