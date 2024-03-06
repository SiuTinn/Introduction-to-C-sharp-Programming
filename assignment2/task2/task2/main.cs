using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task;

namespace task2
{
    internal class main
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose the task:(from 1 to 4)");
            int tag = Convert.ToInt32(Console.ReadLine());
            switch(tag)
            {
                case 1:
                    Console.WriteLine("task1:");
                    Task1 taskOne = new Task1();
                    taskOne.GetPrime();
                    break;
                case 2:
                    Console.WriteLine("task2:");
                    Task2 taskTwo = new Task2();
                    taskTwo.InfoArray();
                    break; 
                case 3:
                    Console.WriteLine("task3:");
                    Task3 taskThree = new Task3();
                    taskThree.PrimeNum();
                    break;
                case 4:
                    Console.WriteLine("task4:");
                    Task4 taskFour = new Task4();
                    taskFour.Matrix();
                    break;
            }

        }
    }
}
