using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    internal class Task4
    {
        public void Matrix()
        {
            Console.WriteLine("Please input the row number:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please input the column number:");
            int col = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[row, col];
            try
            {
                for (int i = 0; i < row; i++)
                {
                    int displayRow = i + 1;
                    Console.WriteLine("input the {0} row", displayRow);
                    string str = Console.ReadLine();
                    string[] tmp = str.Split(' ');
                    for (int j = 0; j < col; j++)
                    {
                        arr[i, j] = Convert.ToInt32(tmp[j]);
                    }
                }
                int baseNum = arr[0, 0];
                bool isMatrix = true;
                for (int i = 0; (i < row) && (i < col); i++)
                {
                    if (arr[i, i] != baseNum)
                    {
                        isMatrix = false;
                        break;
                    }
                }
                if (isMatrix)
                {
                    Console.WriteLine("True");
                }else 
                {
                    Console.WriteLine("False"); }
                }
            catch (Exception ex)
            {
                Console.WriteLine("Wrong input!");
            }
            
        }
    }
}
