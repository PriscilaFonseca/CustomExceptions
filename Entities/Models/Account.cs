using System;
using CustomExceptions.Entities.Exceptions;

namespace CustomExceptions.Entities.Models
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; set; }
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void Deposit(double amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (this.Balance < amount)
            {
                throw new LowBalanceException("Insufficient balance");
            }

            else if (this.WithdrawLimit < amount)
            {
                throw new WithdrawLimitException("The amount exceeds the limit");
            }

            else
            {
                this.Balance -= amount;
            }
        }
    }
}
