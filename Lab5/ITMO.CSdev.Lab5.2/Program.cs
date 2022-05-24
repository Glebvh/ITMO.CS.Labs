using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSdev.LabFive.second
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] a = new int[2, 2];
            int[,] b = new int[2, 2];
            input(a);
            input(b);
            multiply(a, b);
        }
        static void output(int[,] result)
        {
            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
        }
        static int[,] multiply (int [,] a, int [,] b)
        {
            int[,] result = new int[2, 2];
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    result[r, c] = a[r, 0] * b[0, c] + a[r, 1] * b[1, c];
                }
            }


            //result[0, 0] = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            //result[0, 1] = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            //result[1, 0] = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            //result[1, 1] = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];
            output(result);
            return result;

        }
        static void input (int[,] dst)
        {
            for (int r = 0; r < 2; r++)
            {
                for (int c = 0; c < 2; c++)
                {
                    Console.Write("Enter the value for [{0},{1}]: ", r,c);
                    string s = Console.ReadLine();
                    dst[r, c] = int.Parse(s);
                }
            }
            Console.WriteLine();

        }
    }
}
