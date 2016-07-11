using CIDemo.Models;
using CIDemo.Services;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDemo.Tests
{
    [TestFixture]
    public class RectangleTest
    {
        private Rectangle calculator { get; set; }
        [SetUp]
        public void SetUp()
        {
            calculator = new Rectangle();
        }

        [TestCase(0.00, 0.00, Result = 0.00)]
        [TestCase(5.00, 5.00, Result = 20.00)]
        public double CalculateSurface_InputWidthAndHeight_ReturnsCorrectly(double width, double height)
        {
            // Arrange


            // Act
            var result = calculator.CalculateSurface(width, height);

            // Assert
            return result;
        }
    }
}
