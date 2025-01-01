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
        public double WithdrawLimit { get; set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance, double withdrawlLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawlLimit;
        }

        public void Deposit(double amount)
        {            
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount < WithdrawLimit && amount < Balance)
            {
                Balance -= amount;
            }
            else if (amount < WithdrawLimit && amount > Balance)
            {
                throw new DomainException("Insufficient funds");
            }
            else
                throw new DomainException("Exceeded withdraw limit");
        }
    }
}
