using System;
using System.Collections.Generic;
using ExcelBeadPattern;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExcelBeadPatternTest
{
    class UserInputTest
    {
        [TestMethod]
        public void UserInputDispAndGetUserInputNoInputTest()
        {
            //Arrange
            var sw = new StringWriter();
            //This way we don't have to worry about sending in parameters are we are settng what the console will send
            Console.SetOut(sw);
            //Act
            UserInput.dispAndValidUserInput("\n");

            //Assert
            var result = sw.ToString();
            Assert.IsTrue(result.Contains("valid input"));
        }

        [TestMethod]
        public void UserInputDispAndGetUserInputIncorrectInputTest()
        {
            //Act
            String result = UserInput.dispAndValidUserInput("123 14");

            //Assert
            Assert.IsTrue(result.Contains("123 14"));
        }
        [TestMethod]
        public void UserInputAnalyzeUserInputNoInputTest()
        {
            //Arrange             
            String input = "\n";

            //Act
            bool actualResult = UserInput.validateUserInput(input);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void UserInputAnalyzeUserInputTextTest()
        {
            //Arrange             
            String input = "eggaeaer";

            //Act
            bool actualResult = UserInput.validateUserInput(input);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void UserInputAnalyzeUserInputOneNumberTest()
        {
            //Arrange             
            String input = "15";
            //Act
            bool actualResult = UserInput.validateUserInput(input);

            //Assert
            Assert.IsFalse(actualResult);
        }

        //Primes can not be negative
        [TestMethod]
        public void UserInputAnalyzeUserInputNegativeNumberFirstTest()
        {
            //Arrange             
            String input = "-12 15";

            //Act
            bool actualResult = UserInput.validateUserInput(input);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void UserInputAnalyzeUserInputNegativeNumberSecondTest()
        {
            //Arrange             
            String input = "12 -15";
            //Act
            bool actualResult = UserInput.validateUserInput(input);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void UserInputAnalyzeUserInputOneNumberAndTextTest()
        {
            //Arrange             
            String input = "12 awef";

            //Act
            bool actualResult = UserInput.validateUserInput(input);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void UserInputAnalyzeUserInputTwoOrderedNumbersTest()
        {
            //Arrange             
            String input = "7900 7920";

            //Act
            bool actualResult = UserInput.validateUserInput(input);

            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UserInputAnalyzeUserInputTwoReversedNumbersTest()
        {
            //Arrange             
            String input = "7920 7900";

            //Act
            bool actualResult = UserInput.validateUserInput(input);

            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UserInputAnalyzeUserInputTwoSmallNumbersTest()
        {
            //Arrange             
            String input = "1 20";

            //Act
            bool actualResult = UserInput.validateUserInput(input);

            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UserInputAnalyzeUserInputTwoSpacesTest()
        {
            //Arrange             
            String input = "1 20 654";

            //Act
            bool actualResult = UserInput.validateUserInput(input);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void UserInputAnalyzeUserInputOneNumOneSpaceTest()
        {
            //Arrange             
            String input = " 100";

            //Act
            bool actualResult = UserInput.validateUserInput(input);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void UserInputAnalyzeUserInputOneNumOneSpaceLastTest()
        {
            //Arrange             
            String input = "100 ";

            //Act
            bool actualResult = UserInput.validateUserInput(input);

            //Assert
            Assert.IsFalse(actualResult);
        }
        //inputNotQuit
        [TestMethod]
        public void UserInputInputQuitQTest()
        {
            //Arrange             
            String input = "Q";

            //Act
            bool actualResult = UserInput.inputQuit(input);

            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UserInputInputQuitQUITTest()
        {
            //Arrange             
            String input = "QUIT";

            //Act
            bool actualResult = UserInput.inputQuit(input);

            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UserInputInputQuitquitTest()
        {
            //Arrange             
            String input = "quit";

            //Act
            bool actualResult = UserInput.inputQuit(input);

            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UserInputInputQuitExitTest()
        {
            //Arrange             
            String input = "Exit";

            //Act
            bool actualResult = UserInput.inputQuit(input);

            //Assert
            Assert.IsTrue(actualResult);
        }

        [TestMethod]
        public void UserInputInputQuitExitInStringTest()
        {
            //Arrange             
            String input = "THISiSa$tr1ngExitI$houldFAIL";

            //Act
            bool actualResult = UserInput.inputQuit(input);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void UserInputInputQuitNotQuitTest()
        {
            //Arrange             
            String input = "weffw";

            //Act
            bool actualResult = UserInput.inputQuit(input);

            //Assert
            Assert.IsFalse(actualResult);
        }

        [TestMethod]
        public void UserInputInputQuitNumberTest()
        {
            //Arrange             
            String input = "12 36";

            //Act
            bool actualResult = UserInput.inputQuit(input);

            //Assert
            Assert.IsFalse(actualResult);
        }

        //populateNumRange
        [TestMethod]
        public void UserInputPopulateNumRangeOrderedNumberTest()
        {
            //Arrange             
            String input = "12 36";
            int[] expectedResult = { 12, 36 };

            //Act
            int[] actualResult = UserInput.populateNumRange(input);

            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        //populateNumRange
        [TestMethod]
        public void UserInputPopulateNumRangeNotOrderedTest()
        {
            //Arrange             
            String input = "720 1";
            int[] expectedResult = { 1, 720 };

            //Act
            int[] actualResult = UserInput.populateNumRange(input);

            //Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);

        }

        //dispOrderedPrimes
        [TestMethod]
        public void UserInputDispOrderedPrimesTest()
        {
            //Arrange             
            List<int> input = new List<int> { 2, 3 };
            var sw = new StringWriter();

            Console.SetOut(sw);

            //Act
            UserInput.dispOrderedPrimes(input);
            var result = sw.ToString();
            //Assert
            Assert.IsTrue(result.Contains("2, 3"));
        }


        //dispOrderedPrimes
        [TestMethod]
        public void UserInputDispOrderedPrimesNoLastCommaTest()
        {
            //Arrange             
            List<int> input = new List<int> { 2, 3 };
            var sw = new StringWriter();

            Console.SetOut(sw);

            //Act
            UserInput.dispOrderedPrimes(input);
            int length = sw.ToString().Length;
            String disp = sw.ToString();
            var result = disp.Substring(length - 6, 4);
            //Assert
            Assert.IsTrue(result.Equals("2, 3"));
        }

        //Null
        //dispOrderedPrimes
        [TestMethod]
        public void UserInputDispOrderedPrimesNoInputTest()
        {
            //Arrange             
            List<int> input = new List<int> { };
            var sw = new StringWriter();

            Console.SetOut(sw);

            //Act
            UserInput.dispOrderedPrimes(input);
            var result = sw.ToString();
            //Assert
            Assert.IsTrue(result.Contains(""));
        }

        //Main
        [TestMethod]
        public void UserInputMainTest()
        {
            //Arrange             
            //List<int> input = new List<int> { 2, 3 };
            String[] args = new String[0];
            var sw = new StringWriter();
            var sr = new StringReader("2 10");
            Console.SetIn(sr);
            Console.SetOut(sw);

            //Act
            UserInput.Main(args);
            var result = sw.ToString();
            //Assert
            Assert.IsTrue(result.Contains("2, 3, 5, 7"));
        }
    }
}
