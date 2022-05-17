using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._1
{
    internal class Greeter
    {
        static void Main(string[] args)
        {
            string MyName;
            Console.WriteLine("Enter your name:");
            MyName = Console.ReadLine();
            Console.WriteLine("Hello {0}", MyName);
        }
    }
}
