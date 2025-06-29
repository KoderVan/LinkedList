using System;
using Main.Model;

namespace Main
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            /// добавляю значения от 1 до 10
            for (int i = 0; i < 11; i++)
            {
                list.Add(i);
            }

            ListPrinter.Print(list);

            Console.WriteLine();
            /// добавляю значение
            list.InsertAfter(5, 42);
            /// Изменяю
            list.AlterData(9, -1);
            /// Удаляю
            list.Delete(3);
            /// Длина списка
            Console.WriteLine(list.Count);

            list.InsertAfter(10, 5678);
            
            ListPrinter.Print(list);

            list.FindElement(0);
            
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
