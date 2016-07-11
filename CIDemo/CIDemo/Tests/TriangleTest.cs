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

        [TestCase(240, 360)]
        public void TriangleCalculation_WithPositiveValue_ShouldCalculate()
        {
            //arrange
            var width = 360;
            var height = 240;
            var expected = (0.5)*width*height;

            //act
            var actual = ShapeCalculator.CalculateSurface(width, height);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-200, 200)]
        [TestCase(200,-200)]
        public void TriangleCalculation_WithNegativeValue_ShouldReturnPositiveValue(long width, long height)
        {
            //arrange
            var expected = 0.5 * Math.Abs(width*height);

            //act
            var actual = ShapeCalculator.CalculateSurface(width, height);

            //assert
            Assert.IsTrue(actual > 0);
            Assert.AreEqual(expected, actual);
        }

    }
}
