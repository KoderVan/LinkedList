using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Main.Model
{
    public class Item<T>// Что за T 
    {
        /// <summary>
        /// Данные, хранимые в ячейке списка
        /// </summary>
        private T data = default(T);

        public T Data
        {
            get => data;
            set
            {
                if (value != null)
                    data = value; 
                else 
                    throw new ArgumentNullException(nameof(data));
            }
        }
        /// <summary>
        /// Следующая ячейка списка
        /// </summary>
        public Item<T> Next { get; set; }

        public Item(T data)
        {
            Data = data;
        }
        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
