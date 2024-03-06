using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                int n = i;
                while ((num % n) == 0)
                {
                    if (Judge(n))
                    {
                        Console.WriteLine(n);
                        Console.WriteLine(" ");
                    }
                    n = num / n;
                }
            }
        }

        public static bool Judge(int n) //判断是否为素数
        {
            if (n < 2) return false;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }


        
}
