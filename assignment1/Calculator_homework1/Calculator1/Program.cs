using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator1
{
    internal class Calculator_one
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            char c;
            Console.WriteLine("Please input the first number:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please input the operation:");
            c = Convert.ToChar(Console.ReadLine());
            if ((c != '+') && (c != '-') && (c != '*') && (c != '/'))
            {
                Console.WriteLine("Wrong Operation");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Please input the last number:");
                b = Convert.ToDouble(Console.ReadLine());
                if (c == '+')
                {
                    Console.WriteLine("The answer is {0}", a + b);
                    Console.ReadKey();
                }
                else if (c == '-')
                {
                    Console.WriteLine("The answer is {0}", a - b);
                    Console.ReadKey(); ;
                }
                else if (c == '*')
                {
                    Console.WriteLine("The answer is {0}", a * b);
                    Console.ReadKey();
                }
                else if (c == '/')
                {
                    Console.WriteLine("The answer is {0}", a / b);
                    Console.ReadKey();
                }
            }
        }
    }
}
