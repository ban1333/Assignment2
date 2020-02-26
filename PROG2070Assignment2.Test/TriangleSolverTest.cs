using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PROG2070Assignment2.Test
{
    [TestFixture]
    public class TriangleSolverTest
    {
        //PURPOSE makes sure it wouldn't create a triangle
        [Test]
        public void Analyze_Given1And2And3_ResultIsNotTriangle()
        {
            //Arrange
            string expectedResult = "";
            string output = "";
            int input1 = 1;
            int input2 = 2;
            int input3 = 3;

            //Act
            output = TriangleSolver.Analyze(input1, input2, input3);
            expectedResult = "";
            
            //Assert
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void Analyze_Given3And4And5_ResultIsScalene()
        {
            //Arrange
            string expectedResult = "";
            string output = "";
            int input1 = 3;
            int input2 = 4;
            int input3 = 5;

            //Act
            output = TriangleSolver.Analyze(input1, input2, input3);
            expectedResult = "a Scalene";

            //Assert
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void Analyze_Given3And3And3_ResultIsEquilateral()
        {
            //Arrange
            string expectedResult = "";
            string output = "";
            int input1 = 3;
            int input2 = 3;
            int input3 = 3;

            //Act
            output = TriangleSolver.Analyze(input1, input2, input3);
            expectedResult = "an Equilateral";

            //Assert
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void Analyze_Given2And2And3_ResultIsIsosceles()
        {
            //Arrange
            string expectedResult = "";
            string output = "";
            int input1 = 2;
            int input2 = 2;
            int input3 = 3;

            //Act
            output = TriangleSolver.Analyze(input1, input2, input3);
            expectedResult = "an Isosceles";

            //Assert
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void Analyze_GivenNEGATIVE30And40And50_ResultIsNotTriangle()
        {
            //Arrange
            string expectedResult = "";
            string output = "";
            int input1 = -30;
            int input2 = -40;
            int input3 = -50;

            //Act
            output = TriangleSolver.Analyze(input1, input2, input3);
            expectedResult = "";

            //Assert
            Assert.AreEqual(expectedResult, output);
        }

        [Test]
        public void Analyze_Given3And3And4_ResultIsIsosceles()
        {
            //Arrange
            string expectedResult = "";
            string output = "";
            int input1 = 3;
            int input2 = 3;
            int input3 = 4;

            //Act
            output = TriangleSolver.Analyze(input1, input2, input3);
            expectedResult = "an Isosceles";

            //Assert
            Assert.AreEqual(expectedResult, output);
        }
    }
}
