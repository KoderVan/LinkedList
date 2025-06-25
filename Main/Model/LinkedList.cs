using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;

namespace Main.Model
{
    internal class LinkedList<T> : IEnumerable
    {
        /// <summary>
        /// Первый элемент списка
        /// </summary>
        public Item<T> Head { get; private set; }
        /// <summary>
        /// Последний элемент списка
        /// </summary>
        public Item<T> Tail { get; private set; }
        public int Count { get; private set; }
        /// <summary>
        /// Создать пустой спиок
        /// </summary>
        public LinkedList()
        {
            Clear();
        }
        /// <summary>
        /// Создать список с начальным элементом
        /// </summary>
        public LinkedList(T data)
        {
            SetHeadAndTail(data);
        }
        /// <summary>
        /// Добавить данные в конец списка
        /// </summary>
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
        /// <summary>
        /// Удалить первое вхождение в списке
        /// </summary>
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
                SetHeadAndTail(data);
            }
        }
        private void SetHeadAndTail(T data)
        {
            var item = new Item<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        /// <summary>
        /// Добавить данные в начало списка
        /// </summary>
        public void AppendHead(T data)
        {
            var item = new Item<T>(data);
            item.Next = Head;
            Head = item;
            Count++;
        }
        /// <summary>
        /// Вставить элемент после другого элемента
        /// </summary>
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
                        item.Next = current.Next;
                        current.Next = item;
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

        /// <summary>
        /// Очистить список
        /// </summary>
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
        /// <summary>
        /// Изменить имеющееся значение
        /// </summary>
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

        public override string ToString()
        {
            return "Linked List " + Count + " elements"; 
        }
    }
}
