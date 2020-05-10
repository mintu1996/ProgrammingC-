using System;
using System.Threading;
namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Here u can creat the Array of the employee
            Account emp1 = new Account(1,"Ram", 300000);
            Account emp2 = new Account(2,"Devid", 4000000);

            Console.WriteLine("Enter amount:");
            double amount = Convert.ToDouble(Console.ReadLine());

            Management m1 = new Management(emp1, emp2, amount);
            Management m2 = new Management(emp2, emp1, amount);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Before threading start...............................................");
            Console.ForegroundColor = ConsoleColor.White;
            Account.Display(emp1);
            Account.Display(emp2);

            Thread t1 = new Thread(m1.Send); t1.Name = "emp1";
            Thread t2 = new Thread(m2.Send); t2.Name = "emp2";
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("After Threading start........................................................");
            Console.ForegroundColor = ConsoleColor.White;
            Account.Display(emp1);
            Account.Display(emp2);
        }
    }
}
