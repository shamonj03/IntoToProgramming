using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Lesson_1_2_Input.Tests
{
    public class Lesson1_ConsoleOutput_Tests
    {
        [Theory]
        [InlineData("Joe", 26)]
        [InlineData("Kelli", 27)]
        public void EnterDetails_Test(string name, int age)
        {

            using (var sr = new StringReader($"{name}\n{age}"))
            using (var sw = new StringWriter())
            {
                Console.SetIn(sr);
                Console.SetOut(sw);

                var program = new Program();
                program.EnterDetails();

                Assert.Equal($"Please enter your name: Please enter your age: \r\nYour name and age is: {name}, {age}.\r\n", sw.ToString());
            }
        }
    }
}
