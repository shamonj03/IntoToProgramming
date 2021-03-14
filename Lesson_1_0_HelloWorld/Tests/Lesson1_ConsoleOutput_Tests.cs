using Lesson_1_0_HelloWorld;
using System;
using System.IO;
using Xunit;

namespace Leson_1_0_HelloWorld.Tests
{
    public class Lesson1_ConsoleOutput_Tests
    {
        [Fact]
        public void HelloWorld_Test()
        {
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);
                Program.Main(null);

                Assert.Equal("Hello World!\r\n", sw.ToString());
            }
        }
    }
}
