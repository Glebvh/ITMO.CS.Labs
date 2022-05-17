using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the first integer:");
                string temp = Console.ReadLine();
                int i = Convert.ToInt32(temp);
                Console.WriteLine("Please enter the second integer:");
                temp = Console.ReadLine();
                int j = Convert.ToInt32(temp);

                int k = i / j;
                Console.WriteLine("The result ofc dividing {0} by {1} is {2}", i, j, k);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exeption was thrown: {0}", e);
            }

        }
    }
}
