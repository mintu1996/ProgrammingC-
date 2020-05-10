using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Task
{
    class Management
    {
        public Account MoneysendtoAccount { get; set; }
        public Account MoneyWithdrawAccount { get; set; }
        public double TransferMoney { get; set; }
        public Management(Account a, Account b, double amount)
        {
            MoneysendtoAccount = a;
            MoneyWithdrawAccount = b;
            TransferMoney = amount;
        }
        public void PrintDetails()
        {
            Console.WriteLine("From= :"+ MoneysendtoAccount.Id.ToString());
            Console.WriteLine("To= :" + MoneyWithdrawAccount.Id.ToString());
            Console.WriteLine("The amount of money has sent= :" + TransferMoney);
        }
        public void Send()
        {
            object lock1, lock2;
            //In if condition if if u r using the Array of Employee the u can sort the Array of all employee with ids and then place the lock according the u choice what do u want
            if (MoneysendtoAccount.Id < MoneyWithdrawAccount.Id)
            {
                lock1 = MoneysendtoAccount; lock2 = MoneyWithdrawAccount;
            }
            else
            {
                lock1 = MoneyWithdrawAccount; lock2 = MoneysendtoAccount;
            }
            lock (lock1)
            {
                Thread.Sleep(1000);
                lock (lock2)
                {
                    //Console.WriteLine(TransferMoney);
                    if (MoneyWithdrawAccount.Balance > 300000)
                    {
                        MoneyWithdrawAccount.WithDrawAmount(TransferMoney);
                    }
                    else
                    {
                        MoneysendtoAccount.DepositAmount(TransferMoney);
                    }
                    Console.ForegroundColor = ConsoleColor.Red;
                    PrintDetails();
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}
