using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternMatchingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle { Width = 10.0, Height = 20.0 };
            Rectangle r2 = new Rectangle { Width = 10.0, Height = 10.0 };
            Circle c = new Circle { Radius = 5.0 };

            PrintArea(r1);
            PrintArea(r2);
            PrintArea(c);

            Console.ReadLine();
        }

        public static void PrintArea(Shape s)
        {
            //if (s is Rectangle)
            //{
            //    Rectangle r = s as Rectangle;
            //    Console.WriteLine("Area Of Rectangle : " + r.Height * r.Width);

            //}
            //else if (s is Circle)
            //{
            //    Circle c = s as Circle;
            //    Console.WriteLine("Area Of Circle: " + Circle.PI * c.Radius * c.Radius);

            //}


            //if (s is Rectangle r)
            //{
            //    Console.WriteLine("Area Of Rectangle : " + r.Height * r.Width);

            //}
            //else if (s is Circle c)
            //{
            //    Console.WriteLine("Area Of Circle: " + Circle.PI * c.Radius * c.Radius);
            //}

            switch (s)
            {
                case Rectangle r when (r.Width == r.Height):
                    Console.WriteLine("Area Of Square : " + r.Height * r.Width);
                    break;
                case Rectangle r:
                    Console.WriteLine("Area Of Rectangle : " + r.Height * r.Width);
                    break;
                case Circle c:
                    Console.WriteLine("Area Of Circle: " + Circle.PI * c.Radius * c.Radius);
                    break;
            }



        }

    }

    class Shape
    {
        public const double PI = 3.14;
    }
    
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        
    }

    class Circle :Shape
    {
        public double Radius { get; set; }
    }
}
