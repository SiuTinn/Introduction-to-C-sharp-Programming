using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Task3
    {
        public void PrimeNum()
        {
            int[] array = Enumerable.Range(2, 99).ToArray();
            int[] arr2 = { 2, 3, 4, 5,6, 7 ,8,9};
            for(int i = 0; i < 8; i++)
            {
                for(int j = 2; arr2[i] * j <= 100; j++)
                {
                    array = array.Where(val => val != arr2[i] * j).ToArray();
                }
            }
            Console.WriteLine(String.Join(", ", array));
            Console.ReadKey();  
        }
    }
}
