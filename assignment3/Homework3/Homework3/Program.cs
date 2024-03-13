using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//编写面向对象程序实现长方形、正方形、三角形等形状的类。每个形状类都能计算面积、判断形状是否合法。
//请尝试合理使用接口/抽象类、属性来实现。
//随机创建10个形状对象，计算这些对象的面积之和。 尝试使用简单工厂设计模式来创建对象。

namespace Homework3
{
   public interface IShape
    {
        double getArea();
        bool isLegal();

    }

    public class Rectangle : IShape
    {
        private double length { set; get; }
        private double width { set; get; }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
            
        }

        public double getArea()
        {
            return length * width;
        }

        public bool isLegal()
        {
            if (length > 0 && width > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Square : IShape
    {
        private double length { set; get; }


        public Square(double length)
        {
            this.length = length;
            
        }

        public double getArea()
        {
            return length * length;
        }

        public bool isLegal()
        {
            if (length > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Triangle : IShape
    {
        private double a { get; set; }
        private double b { get; set; }
        private double c { get; set; }

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            
        }

        public bool isLegal()
        {
            return (a + b > c) && (a + c > b) && (b + c > a);
        }

        public double getArea()
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
            return area;
        }

    }

    public static class ShapeFactory
    {
        private static Random random = new Random();
        public static IShape CreatShape()
        {
            switch (random.Next(3))
            {
                case 0: 
                    return new Rectangle(random.Next(1, 10), random.Next(1, 10));
                case 1:
                    return new Square(random.Next(1, 10));
                case 2:
                    return new Triangle(random.Next(1, 10),random.Next(1,10),random.Next(1,10));
                default:
                    throw new Exception("Shape Producing Fail");
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            double totalArea = 0;

            for(int i = 0; i<10; i++)
            {
                var shape = ShapeFactory.CreatShape();
                if (shape.isLegal())
                {
                    shapes.Add(shape);
                    totalArea += shape.getArea();
                }
        }
            Console.WriteLine("Total Area is {0}", totalArea);
        }



}






}
