using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CS.Labs.LabSevenTwo
{
    class Utils
    {
        public static void Reverse(ref string f)
        {
            string sRev = "";
            for (int k = f.Length - 1; k >= 0; k--)
            {
                sRev = sRev + f[k];
            }
            f = sRev;
        }
        
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static int Greeter(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
    }
    internal class Program
    {
        static void Main1(string[] args)
        {
            try
            {
                int x;
                int y;
                Console.Write("Enter the first: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Enter the second: ");
                y = int.Parse(Console.ReadLine());
                int greeter;
                greeter = Utils.Greeter(x, y);
                Console.WriteLine("The greeter = " + greeter);
                Console.WriteLine("Before swap: " + x, +y);
                Utils.Swap(ref x, ref y);
                Console.WriteLine("After: " + x, +y);
            }
            catch (System.FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
