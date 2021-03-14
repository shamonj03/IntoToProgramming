using Lesson_1_1_Shapes;
using System;
using System.IO;
using Xunit;

namespace TestProject.Tests
{
    public class Lesson1_ConsoleOutput_Tests
    {
        [Fact]
        public void HardCoded_DrawSquare_Test()
        {
            using(var sw = new StringWriter())
            {
                Console.SetOut(sw);

                var program = new Program();
                program.HardCoded_DrawSquare();

                Assert.Equal("****\r\n****\r\n****\r\n****\r\n", sw.ToString());
            }
        }

        [Fact]
        public void HardCoded_DrawTriangle_Test()
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                var program = new Program();
                program.HardCoded_DrawTriangle();

                Assert.Equal("*\r\n**\r\n***\r\n****\r\n", sw.ToString());
            }
        }


        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "*\r\n")]
        [InlineData(2, "**\r\n**\r\n")]
        [InlineData(3, "***\r\n***\r\n***\r\n")]
        [InlineData(4, "****\r\n****\r\n****\r\n****\r\n")]
        public void Dynamic_DrawSquare_Test(int n, string actual)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                var program = new Program();
                program.Dynamic_DrawSquare(n);

                Assert.Equal(actual, sw.ToString());
            }
        }

        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "*\r\n")]
        [InlineData(2, "*\r\n**\r\n")]
        [InlineData(3, "*\r\n**\r\n***\r\n")]
        [InlineData(4, "*\r\n**\r\n***\r\n****\r\n")]
        public void Dynamic_DrawTriangle_Test(int n, string actual)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                var program = new Program();
                program.Dynamic_DrawTriangle(n);

                Assert.Equal(actual, sw.ToString());
            }
        }

        [Theory]
        [InlineData(0, "")]
        [InlineData(1, "x\r\n")]
        [InlineData(2, "xo\r\nxo\r\n")]
        [InlineData(3, "xox\r\nxox\r\nxox\r\n")]
        [InlineData(4, "xoxo\r\nxoxo\r\nxoxo\r\nxoxo\r\n")]
        public void Dynamic_Alternating_DrawSquare(int n, string actual)
        {
            using (var sw = new StringWriter())
            {
                Console.SetOut(sw);

                var program = new Program();
                program.Dynamic_Alternating_DrawSquare(n);

                Assert.Equal(actual, sw.ToString());
            }
        }
    }
}
