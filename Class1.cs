using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AwesomeCalculator;
using NUnit.Framework;

namespace lab2
{
    [TestFixture]
    public class Class1
    {
        [Test]

        public void GetAddition_Input5point0and5point0_Returns10point0()
        {
            //Arrange
            double number1 = 5;
            double number2 = 5;
            double expectedResult = number1 + number2;
            Calc
            testCalc = new
            Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input6and5_Returns1()
        {
            //Arrange
            double number1 = 6;
            double number2 = 5;
            double expectedResult = number1-number2;
            Calc
            testCalc = new
            Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input5point0and5point0_Returns25point0()
        {
            //Arrange
            double number1 = 5;
            double number2 = 5;
            double expectedResult = number1 * number2;
            Calc
            testCalc = new
            Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);

        }
        [Test]
        public void GetDivision_Input5point0and5point0_Returns0point0()
        {
            //Arrange
            double number1 = 5;
            double number2 = 5;
            double expectedResult = number1 / number2;
            Calc
            testCalc = new
            Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input3point0and5point0_Returns8point0()
        {
            //Arrange
            double number1 = 3;
            double number2 = 5;
            double expectedResult = number1 + number2;
            Calc
            testCalc = new
            Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input13and10_Returns3()
        {
            //Arrange
            double number1 = 13;
            double number2 = 10;
            double expectedResult = number1 - number2;
            Calc
            testCalc = new
            Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]

        public void GetMultiplication_Input6point5and10point0_Returns65point0()
        {
            //Arrange
            double number1 = 6.5;
            double number2 = 10;
            double expectedResult = number1 * number2;
            Calc
            testCalc = new
            Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input15point0and3point0_Returns5point0()
        {
            //Arrange
            double number1 = 15;
            double number2 = 3;
            double expectedResult = number1 /number2;
            Calc
            testCalc = new
            Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetAddition_Input10point0and10point0_Returns20point0()
        {
            //Arrange
            double number1 = 10;
            double number2 = 10;
            double expectedResult = number1 + number2;
            Calc
            testCalc = new
            Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetAddition();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetSubtraction_Input12and10_Returns2()
        {
            //Arrange
            double number1 = 12;
            double number2 = 10;
            double expectedResult = number1 - number2;
            Calc
            testCalc = new
            Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetSubtraction();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetMultiplication_Input12point0and10point0_Returns10point0()
        {
            //Arrange
            double number1 = 1;
            double number2 = 10;
            double expectedResult = number1 * number2;
            Calc
            testCalc = new
            Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetMultiplication();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetDivision_Input12point5and5point0_Returns2point5()
        {
            //Arrange
            double number1 = 12.5;
            double number2 = 5;
            double expectedResult = number1 /number2;
            Calc
            testCalc = new
            Calc(number1, number2);
            //Act 
            double actualResult = testCalc.GetDivision();
            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

    
