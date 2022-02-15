using System;
using System.Collections;

namespace task4
{
    class MyList<T> : IEnumerable, IEnumerator
    {
        private T[] array;
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < array.Length)
                    return array[index];
                throw new IndexOutOfRangeException();
            }
        }
        public int Count => array.Length;

        public MyList()
        {
            array = new T[0];
        }
        public void Add(T item)
        {
            T[] temp = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
                temp[i] = array[i];
            temp[array.Length] = item;
            array = temp;
        }
        public void Remove(T item)
        {
            int n = -1, j = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i].GetHashCode() == item.GetHashCode())
                    n = i;

            if (n == -1)
                return;

            T[] temp = new T[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
                if (i != n)
                {
                    temp[j] = array[i];
                    j++;
                }

            array = temp;
        }
        public void Clear()
        {
            array = new T[0];
        }

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }

        private int position = -1;
        public object Current => array[position];
        public bool MoveNext()
        {
            if (position < array.Length - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
