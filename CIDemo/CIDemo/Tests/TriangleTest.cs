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
        public void Triangle_Calculation(long width, long height)
        {
            var expected = (0.5)*width*height;

            var actual = ShapeCalculator.CalculateSurface(width, height);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(-200, 200)]
        [TestCase(200,-200)]
        public void Triangle_Calculation_WithNegativeValue(long width, long height)
        {
            var expected = 0.5 * Math.Abs(width*height);

            var actual = ShapeCalculator.CalculateSurface(width, height);

            Assert.AreEqual(expected, actual);
        }

    }
}
