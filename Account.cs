using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    class Account
    {
        public int Id { get; set; }
        public double Balance { set; get; }
        public string EmpName { set; get; }
        public Account(int Id,string name, double Balance)
        {
            this.Id = Id;
            this.EmpName = name;
            this.Balance = Balance;
        }
        public void WithDrawAmount(double amount)
        {
            Balance -= amount;
        }
        public void DepositAmount(double amount)
        {
            Balance += amount;
        }
        public static void Display(Account obj)
        {
            Console.WriteLine("//...............................................//");
            Console.WriteLine("Employee's ID= :" + obj.Id);
            Console.WriteLine("The Name of Employee= :" + obj.EmpName);
            Console.WriteLine("Total Balance is = :" + obj.Balance);
        }
    }
}
