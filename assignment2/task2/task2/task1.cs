using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Task1
    {
        public void GetPrime()
        {
            Console.WriteLine("Plz input the number:");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 2;i<=num; i++)
            {
                int tmp = i;
                while (num % tmp == 0)
                {
                    if (isPrime(tmp))
                    {
                        Console.Write(tmp+" ");
                    }
                    num = num / tmp;
                }
            }
        }

        static bool isPrime(int n) 
        {
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if(n % i == 0)
                {
                    return false;
                }
            }return true;
        }
    }
}
