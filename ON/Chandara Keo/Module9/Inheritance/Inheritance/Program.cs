using System;

namespace Inheritance
{
    class Program
    {
        class Shapes //Create class named Shapes with below properties
        {
            public double length;
            public double width;
            public double radius;

            public static void Display(double length, double width, double radius)
            {

                Console.WriteLine("Base length is " + length);
                Console.WriteLine("Base width is " + width);
                Console.WriteLine("Base radius is " + radius);
                Console.WriteLine("\n");
            }
           
        }
        class Rectangle : Shapes
        {
            public void CalArea(double l, double w)
            {
                length = l;
                width = w;
                double RecArea = l * w;
                Console.WriteLine("Rectangle length is: " + length);
                Console.WriteLine("Rectangle width is: " + width);
                Console.WriteLine("Rectangle Area is: " + RecArea);
            }
        }
        class Square : Shapes
        {
            public void CalArea(double a)
            {
                length = a;
                double SqArea = a * a;
                Console.WriteLine("Square side length is: " + a);
                Console.WriteLine("Square Area is: " + SqArea);

            }

        }
        class Circle : Shapes
        {
            public void CalArea(double r)
            {
                radius = r;
                double CirArea = 3.15 * r;
                Console.WriteLine("Circle radius is: " + radius);
                Console.WriteLine("Circal Area is: " + CirArea);

            }
        }
        static void Main(string[] args)
        {
            Rectangle MyRec = new Rectangle();

            Circle MyCir = new Circle();

            Square MySq = new Square();


            Shapes.Display(MyRec.length, MyRec.width, MyRec.radius);


            MyRec.CalArea(3, 4);
            Console.WriteLine("\n");

            MySq.CalArea(10);
            Console.WriteLine("\n");

            MyCir.CalArea(8);
        }
    }
}
