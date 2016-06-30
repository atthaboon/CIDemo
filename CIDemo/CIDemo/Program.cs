using CIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Automate Shape Workshop");

            var rectangle = new Rectangle(5, 4);
            // Console.WriteLine($"Rectangle surface is {rectangle.CalculateSurface()}");

            var triangle = new Triangle(5, 4);
            // Console.WriteLine($"Triangle surface is {triangle.CalculateSurface()}");

            var circle = new Circle(5, 4);
            // Console.WriteLine($"Circle surface is {circle.CalculateSurface()}");

            Console.ReadLine();
        }
    }
}
