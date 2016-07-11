using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDemo.Models
{
    public class Triangle : IShapeCalculate
    {
        public double CalculateSurface(double width, double height)
        {
            var area = 0.5 * width * height;
            return area;

        }
    }
}
