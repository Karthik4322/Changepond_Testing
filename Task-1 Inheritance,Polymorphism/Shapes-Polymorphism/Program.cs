using System;

namespace Tasks
{
    public abstract class Shape
    {
        Location l1 = new Location();
        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            return "call any methods";
        }
    }

    public class Location
    {
        private int x;
        private int y;
    }

    public class Rectangle : Shape
    {
        int length;
        int width;

        public Rectangle(int l, int w)
        {
            this.length = l;
            this.width = w;
        }

        public override double Area()
        {
            return length * width;
        }

        public override double Perimeter()
        {
            return 2 * (length + width);
        }
    }

    public class Circle : Shape
    {
        int radius;

        public Circle(int r)
        {
            this.radius = r;
        }

        public override double Area()
        {
            return 3.14 * radius * radius;
        }

        public override double Perimeter()
        {
            return 2 * 3.14 * radius;
        }
    }

    class Program
    {
        private static void Main(string[] args)
        {
            Rectangle r = new Rectangle(3, 8);
            Console.WriteLine($"Rectangle Area: {r.Area()}");
            Console.WriteLine($"Rectangle Perimeter: {r.Perimeter()}");

            Circle c = new Circle(3);
            Console.WriteLine($"Circle Area: {c.Area()}");
            Console.WriteLine($"Circle Perimeter: {c.Perimeter()}");
        }
    }
}
