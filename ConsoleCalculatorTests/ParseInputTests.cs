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
            parse.ParseUInput(normalInputString);
            Assert.IsNotNull(parse.holding[0]);
            Assert.IsNotNull(parse.holdingChar[0]);
        }

        [TestMethod()]
        public void tryingTestBlank()
        {
            ParseInput parse1 = new ParseInput();
            string blankInputString = "";
            parse1.ParseUInput(blankInputString);
            Assert.IsNull(parse1.holding[0]);
            Assert.IsNull(parse1.holdingChar[0]);
        }

        [TestMethod()]
        public void tryingTestSpace()
        {
            ParseInput parse2 = new ParseInput();
            string spaceInputString = " ";
            parse2.ParseUInput(spaceInputString);
            Assert.IsNull(parse2.holding);
            Assert.IsNull(parse2.holdingChar);
        }

        [TestMethod()]
        public void tryingTestMultiSpace()
        {
            ParseInput parse3 = new ParseInput();
            string multiSpaceInputString = "      ";
            parse3.ParseUInput(multiSpaceInputString);
            Assert.IsNull(parse3.holding);
            Assert.IsNull(parse3.holdingChar);
        }

        [TestMethod()]
        public void StoreInputTests()
        {
            string storeInputTestString = " 44 * 3 + 22";
            ParseInput parse4 = new ParseInput();
            parse4.StoreInput(storeInputTestString);
            if (parse4.storedProcedures.ContainsValue(storeInputTestString))
            {
                Assert.AreEqual(1, 1);
            }
            else { Assert.Fail(); }
        }

        [TestMethod()]
        public void CallInput()
        {
            ParseInput parse5 = new ParseInput();
            parse5.storedProcedures.Add(1, "you've found the test string!");
            string tempString = parse5.storedProcedures[1];
            parse5.ParseUInput(tempString);
            Assert.IsNotNull(parse5.holding);
        }

        //[TestMethod()]
        //public void StringPerenTest()
        //{
        //    Assert.Fail();
        //}

        //[TestMethod()]
        //public void DoMathTest()
        //{
        //    Assert.Fail();
        //}
    }
}