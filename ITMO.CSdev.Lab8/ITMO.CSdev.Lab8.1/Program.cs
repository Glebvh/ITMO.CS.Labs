using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSdev.Lab.Eight.Two
{
    enum AccountType
    {
        Checking, Deposit
    }

    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;

        private static long nextNumber = 123;

        private Queue tranQueue = new Queue();

        public BankAccount()
        {
            accNo = NextNumber();
            accBal = 0;
            accType = AccountType.Checking;
            Console.WriteLine(accType);
            Console.WriteLine(accNo);
        }

        public BankAccount(AccountType aType)
        {
            accType = aType;
            accBal = 0;
            accNo = NextNumber();
            Console.WriteLine(accType);
            Console.WriteLine(accNo);
        }
        public BankAccount(decimal aBal)
        {
            accType = AccountType.Checking;
            accBal = aBal;
            accNo = NextNumber();
            Console.WriteLine(accType);
            Console.WriteLine(accNo);
        }
        public BankAccount(AccountType aType, decimal aBal)
        {
            accType = aType;
            accBal = aBal;
            accNo = NextNumber();
            Console.WriteLine(accType);
            Console.WriteLine(accNo);
        }
        public bool Withdraw(decimal amount)
        {
            bool sufficientFunds = accBal >= amount;
            if (sufficientFunds)
            {
                accBal -= amount;
                BankTransaktion tran = new BankTransaktion(-amount);
                tranQueue.Enqueue(tran);

            }
            return sufficientFunds;
        }

        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            BankTransaktion tran = new BankTransaktion(amount);
            tranQueue.Enqueue(tran);
            return accBal;
        }

        public Queue Transactions()
        {
            return tranQueue;
        }
        public long Number()
        {
            return accNo;
        }
        public decimal Balance()
        {
            return accBal;
        }
        public string Type()
        {
            return accType.ToString();
        }
        private static long NextNumber()
        {
            return nextNumber++;
        }
    }
    class CreateAccount
    {
        static void Main()
        {
            BankAccount acc1 = new BankAccount();
            acc1.Deposit(100);
            acc1.Withdraw(50);
            acc1.Deposit(75);
            acc1.Withdraw(50);
            acc1.Withdraw(30);
            acc1.Deposit(40);
            acc1.Deposit(200);
            acc1.Withdraw(250);
            acc1.Deposit(25);

            BankAccount acc2 = new BankAccount(AccountType.Deposit);
            BankAccount acc3 = new BankAccount(100);
            BankAccount acc4 = new BankAccount(AccountType.Deposit, 500);


            Write(acc1);
            Write(acc2);
            Write(acc3);
            Write(acc4);
        }

        static void Write(BankAccount acc)
        {
            Console.WriteLine("Account number is {0}", acc.Number());
            Console.WriteLine("Account balance is {0}", acc.Balance());
            Console.WriteLine("Account type is {0}", acc.Type());
            Console.WriteLine("Transactions: ");
            foreach (BankTransaktion tran in acc.Transactions())
            {
                Console.WriteLine("Date/Time: {0}\t Amount {1}", tran.When(), tran.Amount());
            }
        }
    }
    class BankTransaktion
    {
        private readonly decimal amount;
        private readonly DateTime when;
        public decimal Amount()
        {
            return amount;
        }
        public DateTime When()
        {
            return when;
        }
        public BankTransaktion(decimal tranAmount)
        {
            amount = tranAmount;
            when = DateTime.Now;
        }


    }
}
