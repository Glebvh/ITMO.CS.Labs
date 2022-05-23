using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4._3
{
    class Utils
    {
        public static bool Factorial (int n, out int answer)
        {
            int k;
            int f;
            bool ok = true;
            if (n < 0)
                ok = false;

            try
            {
                checked
                {                    
                    f=1;
                    for (k = 2; k <= n; k++)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception ex)
            {
                f=0;
                ok = false;
                Console.WriteLine(ex.Message);
            }
            answer = f;
            return ok;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int f;
            bool ok;
            int x;
            Console.Write("Insert integer: ");
            x = int.Parse(Console.ReadLine());
            ok = Utils.Factorial(x, out f);
            if (ok)
                Console.WriteLine("Factorial (" + x + ") = " + f);
            else
                Console.WriteLine("Cant compute this factorial");
        }
    }
}
