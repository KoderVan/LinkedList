using System;
using System.Collections;

namespace Main.Model
{
    public static class ListPrinter
    {
        public static void Print(IEnumerable list)
        {
            if (list == null)
            {
                Console.WriteLine("Список пуст (null)");
                return;
            }

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
