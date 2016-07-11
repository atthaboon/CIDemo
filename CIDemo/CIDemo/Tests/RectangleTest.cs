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
    public class RectangleTest
    {
        private IShapeCalculate ShapCalculate;
        public void Setup()
        {
            ShapCalculate  = new Rectangle();   
        }

        [Test]
        public void Rectangle_Calculation()
        {
            var width = 240;
            var height = 360;

            var actual = ShapCalculate.CalculateSurface(width, height);

            Assert.AreEqual(width*height, actual);
        }

    }
}
