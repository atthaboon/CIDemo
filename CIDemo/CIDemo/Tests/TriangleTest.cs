using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CIDemo.Models;
using NUnit.Framework;

namespace CIDemo.Tests
{
    [TestFixture]
    public class TriangleTest
    {
        private IShapeCalculate ShapeCalculator;

        [SetUp]
        public void Setup()
        {
            ShapeCalculator  = new Triangle();   
        }

        [Test]
        public void TriangleCalculation_WithPositiveValue_ShouldCalculate()
        {
            //Arrange
            var width = 2;
            var height = 4;

            //Act
            var actual = ShapeCalculator.CalculateSurface(width, height);

            //Assert
            Assert.AreEqual(4, actual);
        }

        [TestCase(-200, 200)]
        [TestCase(200,-200)]
        public void TriangleCalculation_WithNegativeValue_ShouldReturnPositiveValue(long width, long height)
        {

            //Act
            var actual = ShapeCalculator.CalculateSurface(width, height);

            //Assert
            Assert.IsTrue(actual > 0);
            Assert.AreEqual(20000d, actual);
        }

    }
}
