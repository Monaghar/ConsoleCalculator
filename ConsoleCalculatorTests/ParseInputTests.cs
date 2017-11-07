using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator.Tests
{
    [TestClass()]
    public class ParseInputTests
    {

        
        [TestMethod()]
        public void tryingTestNormal()
        {
            ParseInput parse = new ParseInput();
            string normalInputString = "44 + 22 * 2";
            parse.Parseinput(normalInputString);
            Assert.IsNotNull(parse.Holding);
            Assert.IsNotNull(parse.HoldingChar);
        }

        [TestMethod()]
        public void tryingTestBlank()
        {
            ParseInput parse1 = new ParseInput();
            string blankInputString = "";
            parse1.Parseinput(blankInputString);
            Assert.IsNull(parse1.Holding);
            Assert.IsNull(parse1.HoldingChar);
        }

        [TestMethod()]
        public void tryingTestSpace()
        {
            ParseInput parse2 = new ParseInput();
            string spaceInputString = " ";
            parse2.Parseinput(spaceInputString);
            Assert.IsNull(parse2.Holding);
            Assert.IsNull(parse2.HoldingChar);
        }

        [TestMethod()]
        public void tryingTestMultiSpace()
        {
            ParseInput parse3 = new ParseInput();
            string multiSpaceInputString = "      ";
            parse3.Parseinput(multiSpaceInputString);
            Assert.IsNull(parse3.Holding);
            Assert.IsNull(parse3.HoldingChar);
        }

        [TestMethod()]
        public void StringPerenTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DoMathTest()
        {
            Assert.Fail();
        }
    }
}