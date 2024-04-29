using CSharpCompleto.Entities.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpCompleto.Entities
{
    public class Account
    {
        public int Number { get; set; } 
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawlLimit { get; set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance, double withdrawlLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawlLimit = withdrawlLimit;
        }

        public void Deposit(double amount)
        {            
            Balance += amount;
        }

        public void Withdrawl(double amount)
        {
            if (amount < WithdrawlLimit)
            {
                Balance -= amount;
            }
            else if (Balance < amount)
            {
                throw new DomainException("Insufficient funds");
            }
            else
                throw new DomainException("Exceeded withdrawl limit");
        }
    }
}
