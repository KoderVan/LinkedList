using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Main.Model;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>();
            /// добавляю значения от 1 до 10
            for (int i = 0; i < 11; i++)
            {
                list.Add(i);
            }
            /// вывожу список
            foreach(var item in list)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
            /// добавляю значение
            list.InsertAfter(5, 42);
            /// Изменяю
            list.AlterData(9, -1);
            /// Удаляю
            list.Delete(3);
            /// Длина списка
            Console.WriteLine(list.Count);

            //Item<string> test = new Item<string>("sdswf");
            //list.Add(test);

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
