using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1;
using NUnit.Framework;

namespace SENG8040_Assignment1
{
    [TestFixture]
    class SENG8040_Assignment1_Tests
    {
        [Test]
        public void GetLength_input2_expectedLengthEquals2()
        {
            //Arrange
            int l = 2;
            int w = 3;
            Rectclass testRectangle = new Rectclass(l, w);

            //Act
            int length = testRectangle.GetLength();

            //Assert
            Assert.AreEqual(l, length);
        }
        [Test]
        public void SetLength_input4_expectedLengthEquals4()
        {
            //Arrange
            int l = 4;
            int w = 3;
            Rectclass testRectangle = new Rectclass(l, w);

            //Act
            int length = testRectangle.SetLength(l);

            //Assert
            Assert.AreEqual(l, length);
        }
        [Test]
        public void GetWidth_input3_expectedLengthEquals3()
        {
            //Arrange
            int l = 4;
            int w = 3;
            Rectclass testRectangle = new Rectclass(l, w);

            //Act
            int width = testRectangle.GetWidth();

            //Assert
            Assert.AreEqual(w,width);
        }
        [Test]
        public void SetWidth_input6_expectedWidthEquals6()
        {
            //Arrange
            int l = 4;
            int w = 6;
            Rectclass testRectangle = new Rectclass(l, w);

            //Act
            int width = testRectangle.SetWidth(w);

            //Assert
            Assert.AreEqual(w, width);
        }
        [Test]
        public void GetPerimeter_input3and6_expectedLengthPerimeter18()
        {
            //Arrange
            int l = 4;
            int w = 6;
            Rectclass testRectangle = new Rectclass(l, w);

            //Act
            int length = testRectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(l, length);
        }
        [Test]
        public void GetArea_input3and6_expectedLengthEquals24()
        {
            //Arrange
            int l = 4;
            int w = 6;
            Rectclass testRectangle = new Rectclass(l, w);

            //Act
            int length = testRectangle.GetArea();

            //Assert
            Assert.AreEqual(l, length);



        }








    }

}
