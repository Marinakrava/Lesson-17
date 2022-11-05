using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_17
{
    internal class BankAccount <T>
    {
         T Id { get; set; }
         string Name { get; set; }
         double Balance { get; set; }

        public string GetInfo()
        {
            return $"{Id} {Name} {Balance}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер банковского счета");
            string idString = Console.ReadLine();
            Id = (T)Convert.ChangeType(idString, typeof(T)); 

            Console.WriteLine("Введите Фамилию Имя Отчество");
            Name = Console.ReadLine();

            Console.WriteLine("Введите баланс счета");
            Balance = Convert.ToDouble(Console.ReadLine()); 
        }

    }
}
