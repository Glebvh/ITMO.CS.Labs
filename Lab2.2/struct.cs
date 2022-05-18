using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._2
{
    public enum AccountType { Checking, Deposit };
    public struct BankAccount
        {
            public long accNo;
            public decimal accBal;
            public AccountType accType;
        }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount goldAccount;
            goldAccount.accType = AccountType.Checking;
            goldAccount.accBal = (decimal)3200.00;
            goldAccount.accNo = 123;

            Console.WriteLine("*** Account summary ***");
            Console.WriteLine("Acct number {0}", goldAccount.accNo);
            Console.WriteLine("Acct type {0}", goldAccount.accType);
            Console.WriteLine("Acct ballance ${0}", goldAccount.accBal);
        }
    }
}
