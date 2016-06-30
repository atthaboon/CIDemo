using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDemo.Models
{
    public abstract class Shape : IShapeCalculate
    {
        private const string NegativeSideExceptionMsg = "Value must be positive.";

        private double width;
        private double height;

        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(NegativeSideExceptionMsg);
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(NegativeSideExceptionMsg);
                }

                this.height = value;
            }
        }

        public abstract double CalculateSurface();
    }
}
