using System;
using System.Collections;

namespace Main.Model
{
    public class LinkedList<T> : IEnumerable
    {
        /// Первый элемент списка
        public Item<T> Head { get; private set; }
        /// Последний элемент списка
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }
        /// Создать пустой спиок
        public LinkedList()
        {
            Clear();
        }
        /// Создать список с начальным элементом
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }
        /// Добавить данные в конец списка
        public void Add(T data)
        {
            if (Tail != null)
            {
                var item = new Item<T>(data);
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(data);
            }
        }
        /// Удалить первое вхождение в списке
        public void Delete(T data)
        {
            if (Head != null)
            {
                if (Head.Data.Equals(data))
                {
                    Head = Head.Next;
                    Count--;
                    return;
                }
                var current = Head.Next;
                var previous = Head;

                while (current != null)
                {
                    if (current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
            else
            {
                Console.WriteLine("Такого элемента в списке нет");
            }
        }
        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        /// Добавить данные в начало списка
        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }
        /// Вставить элемент после другого элемента
        public void InsertAfter(T target, T data)
        {
            if (Head != null)
            {
                
                var current = Head;
                while (current != null)
                {

                    if (current.Data.Equals(target))
                    {
                        var item = new Item<T>(data);
                        if (current.Next == null)
                        {
                            current.Next = item;
                            item.Next = null;
                            Tail = item;

                        }
                        else
                        {
                            item.Next = current.Next;
                            current.Next = item;
                        }
                        Count++;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }
        /// Очистить список
        public void Clear()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null) 
            {
                yield return current.Data;
                current = current.Next;
            }
        }
        /// Изменить имеющееся значение
        public void AlterData(T target, T data)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        current.Data = data;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }
            }
        }

        public void FindElement(T target)
        {
            if (Head != null)
            {
                var current = Head;
                while (current != null)
                {
                    
                    if (current.Data.Equals(target))
                    {
                        Console.WriteLine($"\ntarget Head: {current}");
                        Console.WriteLine($"target Next: {current.Next}");
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                    
                }
                Console.WriteLine("Такого элемента нет в списке");
            }
            else
            {
                Console.WriteLine("Список пуст");
            }
        }
        public override string ToString()
        {
            return "Linked List " + Count + " elements"; 
        }
    }
}
