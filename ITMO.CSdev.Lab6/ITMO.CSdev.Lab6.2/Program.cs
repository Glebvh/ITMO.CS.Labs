using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.CSdev.LabSix.F
{
    public enum AccountType { Checking, Deposit }
    class BankAccount
    {
        private long accNo;
        private decimal accBal;
        private AccountType accType;
        public static long nextAccNo = 123;
        public void Populate(decimal balance)
        {
            accNo = NextNumber();
            accBal = balance;
            accType = AccountType.Checking;
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
            return nextAccNo++;
        }

        public decimal Deposit(decimal amount)
        {
            accBal += amount;
            if (accBal < 0)
            {
                Console.WriteLine("Warning");
            }
            return accBal;
        }
        public bool WithDraw(decimal amount)
        {
            bool suficientFunds = accBal >= amount;
            if (suficientFunds)
            {
                accBal -= amount;
            }
            else
            {
                Console.WriteLine("Balance is low: " + accBal);
            }
            
            return suficientFunds;
        }
        public static void TestWithdraw(BankAccount acc)
        {
            Console.Write("Enter required sum: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            if (!acc.WithDraw(amount))
            {
                Console.WriteLine("Insufficient funds");
            }
        }
        
    }
    class CreateAccount
    {
        public static void TestDeposit(BankAccount acc)
        {
            Console.Write("Enter amount to deposit: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            acc.Deposit(amount);
        }
        static void Main(string[] args)
        {
            BankAccount berts = NewBankAccount();
            Write(berts);
            TestDeposit(berts);
            Write(berts);
            BankAccount.TestWithdraw(berts);
            Write(berts);

            BankAccount freds = NewBankAccount();
            Write(freds);
            TestDeposit(freds);
            Write(freds);
            BankAccount.TestWithdraw(freds);
            Write(freds);
        }

        static BankAccount NewBankAccount()
        {
            BankAccount created = new BankAccount();

            Console.Write("Enter the account balance!: ");
            decimal balance = decimal.Parse(Console.ReadLine());

            created.Populate(balance);

            return created;
        }

        static void Write(BankAccount toWrite)
        {
            Console.WriteLine("Account number is {0}", toWrite.Number());
            Console.WriteLine("Account balance is {0}", toWrite.Balance());
            Console.WriteLine("Account type is {0}", toWrite.Type());
        }
    }

}

