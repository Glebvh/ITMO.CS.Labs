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
            try 
           
            {
                Console.Write("Please enter the year: ");
                string line = Console.ReadLine();
                int yearNum = int.Parse(line);
                bool isLeapYear = (yearNum % 4 == 0) && (yearNum % 100 != 0 || yearNum % 400 == 0);
                    
                    int maxDayNum = isLeapYear ? 366 : 365;
                    Console.WriteLine("Enter the number of day between 1 and {0}", maxDayNum);
                                        
                line = Console.ReadLine();
                int dayNum = int.Parse(line);

                    if (dayNum < 1 || dayNum > maxDayNum)
                    {
                        throw new ArgumentOutOfRangeException("Day out of range");
                    }


                int monthNum = 0;
                var daysInMonths = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                var daysInLeapMonths = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                    if (isLeapYear) 
                    {
                      foreach (int daysInMonth in daysInLeapMonths)
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
                    }
                else
                    {
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
                    }
                
                monthName temp = (monthName)monthNum;
                string monthName = temp.ToString();

                Console.WriteLine("{0} {1}", dayNum, monthName);
            
             }
                catch (Exception caught) {
                    Console.WriteLine (caught);
                        }

            }
        }
    }

}
