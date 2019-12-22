using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp43
{
    class Point 
    {
        protected double x;
        protected double y;
        public double Getx()
        {
            return this.x;
        }
        public double Gety()
        {
            return this.y;
        }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Shape
    {
        protected Point pr;

        public Shape(Point pr)
        {
            this.pr = pr;
        }
    }
    class ThreeDShape:Shape 
    {
        protected const int D=3;
        public ThreeDShape(Point pr):base (pr)
        {
        
        }

    }
    class TwoDShape:Shape 
    {
        protected const int D = 2;
        public TwoDShape(Point pr):base(pr)
        {

        }
    }
    class Cube : ThreeDShape
    {
        protected string name;
        protected double length;
        protected double height;
        protected double width;

        public Cube(string name, double length, double height, double width,Point pr):base (pr)
        {
            this.name = name;
            this.length = length;
            this.height = height;
            this.width = width;
        }
    }
    class Sphere:ThreeDShape
    {
        protected string name;
        protected double radius;

        public Sphere(string name, double radius, Point pr):base (pr)
        {
            this.name = name;
            this.radius = radius;
        }
        public void PrintVolume()
        {
            Console.WriteLine(this.radius*this.radius*this.radius*Math.PI*4/3);
        }
    }
    class Circle : TwoDShape
    {
        protected string name;
        protected double radius;

        public Circle(string name, double radius,Point pr):base(pr)
        {
            this.name = name;
            this.radius = radius;
        }
        public void ToString()
        {
            Console.WriteLine(this.name);
            Console.WriteLine(this.pr.Getx());
            Console.WriteLine(this.pr.Gety());
            Console.WriteLine(this.radius);
            Console.WriteLine("the shape has "+D+" dimentions");
        }
        public void PrintArea()
        {
            
            Console.WriteLine("the area is "+this.radius*this.radius*Math.PI);
        }
    }
    class Square : TwoDShape
    {
        protected string name;
        protected double width;
        protected double length;

        public Square(string name, double width, double length,Point pr):base(pr)
        {
            this.name = name;
            this.width = width;
            this.length = length;
        }
        public void PrintArea()
        {
            Console.WriteLine(this.width*this.length);
        }
    }
    

}
