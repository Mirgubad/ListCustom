using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ListCustom
{
    class Mylist<T> :IEnumerable

    {
        private int _size = 0;
        public int Capacity { get; set; }

        public int Size
        {
            get { return _size; }
        }
        private T[] data;
        public bool IsEmpty
        {
            get
            {
                return Size == 0;
            }
        }
        public Mylist(int capacity = 8)
        {

            if (capacity < 1)
            { capacity = 1; }
            this.Capacity = capacity;
            data = new T[capacity];

        }

        private void Resize()
        {
            T[] resized = new T[Capacity * 2];
            for (int i = 0; i < Capacity; i++)
            {
                resized[i] = data[i];

            }
            data = resized;
            Capacity = Capacity * 2;
        }
    public void Add(T element)
        {
            if (_size == Capacity)
            {
                Resize();
            }  data[_size] = element;
            _size++;    
        }

        public void Clear()
        {
            data = new T [Capacity];
            _size = 0;

        }
        
        public bool Contains(T value)
        {
            for (int i = 0; i < _size; i++)
            {
              
                if (data[i].Equals(value))
                {
                    return true;
                }
            }
            return false;
        }

        public void Insert(T element,int index)
        {
            if (_size == Capacity)
            {
                Resize();
            }

            for (int i = _size; i > index; i--)
            {
                data[i] = data[i - 1];

            }
            data[index] = element;
            _size++;
        }
        public void Remove(int index)
        {
            for (int i = index; i < _size-1; i++)
            {
                data[i] = data[i + 1];

            }data[_size-1] =default (T);
            _size--;
        }
        public IEnumerator GetEnumerator()
        {
            data.GetEnumerator();
            foreach (var item in data)
            {
                if(item.GetType()!=default)
                {
                    yield return item;
                }
            }
        }
    
    }
}
