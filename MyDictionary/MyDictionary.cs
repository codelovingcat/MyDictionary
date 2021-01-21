using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class MyDictionary<T>
    {
        T[] _items;
        public MyDictionary()
        {
            _items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = _items;
            _items = new T[_items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                _items[i] = tempArray[i];
            }

            _items[_items.Length - 1] = item;
        }
        public T[] List
        {
            get { return _items; }
        }

    }
}
