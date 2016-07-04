using CIDemo.Models;
using CIDemo.Services;
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

            var rectangle = new Rectangle();
            // Console.WriteLine($"Rectangle surface is {rectangle.CalculateSurface(5, 4)}");

            var triangle = new Triangle();
            // Console.WriteLine($"Triangle surface is {triangle.CalculateSurface(5, 4)}");

            var circle = new Circle();
            // Console.WriteLine($"Circle surface is {circle.CalculateSurface(5, 4)}");

            Console.ReadLine();
        }


        /*
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Automate Shape Workshop 2");

            var rectangle = new Rectangle();
            var shapeCalculateService = new ShapeCalculateService(rectangle);
            shapeCalculateService.PrintCalculateTotalSurface(5, 4);

            var triangle = new Triangle();
            var shapeCalculateService2 = new ShapeCalculateService(triangle);
            shapeCalculateService2.PrintCalculateTotalSurface(5, 4);

            var circle = new Circle();
            var shapeCalculateService3 = new ShapeCalculateService(circle);
            shapeCalculateService3.PrintCalculateTotalSurface(5, 4);

            Console.ReadLine();
        }
        */

    }
}
