using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDemo.Models
{
    public interface IShapeCalculate
    {
        double CalculateSurface(double width, double height);
    }
}
