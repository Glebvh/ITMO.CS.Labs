using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3._1
{
    internal class Program
    {
        class WhatDay
        {
            public enum monthName { Jan, Feb, Mar, Apr, May, Jun, Jul, Aug, Sep, Oct, Nov, Dec };
            
            static void Main(string[] args)
            {
                Console.Write("Please enter the day number:");
                string line = Console.ReadLine();
                int dayNum = int.Parse(line);

                int monthNum = 0;
                var daysInMonths = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                foreach (int daysInMonth in daysInMonths)
                {
                    if (dayNum <= daysInMonth)
                    {
                        break;
                    }
                    else
                    {
                        dayNum = dayNum - daysInMonth;
                        monthNum++;
                    }
                }
                
           
                monthName temp = (monthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);

            }
        }
    }

}
