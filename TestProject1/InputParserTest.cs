using Autofac.Extras.Moq;
using ClassLibrary1;
using InputParser_using_delegates;
//using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Text.Json;
//using InputParser_using_delegates.Program;
using Assert = Xunit.Assert;
using System.Reflection.Metadata;

namespace TestProject1
{

    public class InputParserTest
    {

        [Fact]
        public void onWordTest()
        {
            string outp = "input string contains group of words : called onWord";
            var mock = new Mock<InputParserDelegate>();
            mock.Setup(p => p(It.IsAny<string>())).Returns(ConsoleReader.Word);

            var actual = ConsoleReader.Word("Abc");

            Assert.Equal(outp, actual);
        }

        [Fact]
        public void onNumTest()
        {
            
            string op = "input string contains group of numbers: called onNum";
            var mock = new Mock<InputParserDelegate>();
            mock.Setup(p => p(It.IsAny<string>())).Returns(ConsoleReader.Num);

            var actual = ConsoleReader.Num("123");

            Assert.Equal(op, actual);
        }
        [Fact]
        public void onJunkTest()
        {

            string op = "input string contains special characters : called onJunk";
            var mock = new Mock<InputParserDelegate>();
            mock.Setup(p => p(It.IsAny<string>())).Returns(ConsoleReader.Junk);

            var actual = ConsoleReader.Junk("#$%");
           
            Assert.Equal(op, actual);
        }

    }
}
    