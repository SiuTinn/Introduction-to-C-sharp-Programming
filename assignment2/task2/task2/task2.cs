using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Task2
    {
        public void InfoArray()
        {
            int length = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[length]; 
            for(int i = 0; i < length; i++)
            {
                int tmp = i + 1;
                Console.WriteLine("input the {0} number" , tmp);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(array);
            int max = array[length-1];
            int min = array[0];
            int sum = array.Sum();
            int average = sum / length;
            Console.WriteLine("Max is {0}", max);
            Console.WriteLine("Min is {0}", min);
            Console.WriteLine("Sum is {0}", sum);
            Console.WriteLine("average is {0}", average);
            Console.ReadKey();

        }
    }
}
