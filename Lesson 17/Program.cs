using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            BankAccount<int> account1 = new BankAccount<int>();
            account1.Input();
            Console.WriteLine(account1.GetInfo());

            BankAccount<string> account2 = new BankAccount<string>();
            account2.Input();
            Console.WriteLine(account2.GetInfo());
            Console.ReadKey();
        }
    }
}
