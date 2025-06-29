using System;

namespace Main.Model
{
    public class Item<T> 
    {
        /// Данные, хранимые в ячейке списка
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
        /// Следующая ячейка списка
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
