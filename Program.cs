using System;
using CustomExceptions.Entities.Models;
using CustomExceptions.Entities.Exceptions;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string holder;
            double balance, limit;
            Account account;

            try
            {
                Console.WriteLine("Enter account data");

                Console.Write("Number: ");
                number = int.Parse(Console.ReadLine());

                Console.Write("Holder: ");
                holder = Console.ReadLine();

                Console.Write("Initial Balance: ");
                balance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw limit: ");
                limit = double.Parse(Console.ReadLine());

                account = new Account(number, holder, balance, limit);

                Console.WriteLine("Enter amount for withdraw: ");
                account.Withdraw(double.Parse(Console.ReadLine()));
                Console.WriteLine($"New Balance: {account.Balance}");
            }

            catch (LowBalanceException obj)
            {
                Console.WriteLine(obj.Message);
            }
            catch (WithdrawLimitException obj)
            {
                Console.WriteLine(obj.Message);
            }

        }
    }
}
