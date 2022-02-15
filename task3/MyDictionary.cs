using System;
using System.Collections;

namespace task3
{
    class MyDictionary<TKey, TValue> : IEnumerable, IEnumerator
    {
        private TKey[] keys;
        private TValue[] values;
        public TValue[] this[TKey index]
        {
            get
            {
                TValue[] tempValues = new TValue[0];
                for (int i = 0; i < keys.Length; i++)
                    if (keys[i].ToString() == index.ToString())
                    {
                        TValue[] temp = new TValue[tempValues.Length + 1];
                        for (int j = 0; j < tempValues.Length; j++)
                            temp[j] = tempValues[j];
                        temp[tempValues.Length] = values[i];
                        tempValues = temp;
                    }
                return tempValues;
            }
        }
        public int Count => values.Length;

        public MyDictionary()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] tempKeys = new TKey[keys.Length + 1];
            TValue[] tempValues = new TValue[values.Length + 1];
            for (int i = 0; i < keys.Length; i++)
                tempKeys[i] = keys[i];
            for (int i = 0; i < values.Length; i++)
                tempValues[i] = values[i];
            tempKeys[keys.Length] = key;
            tempValues[values.Length] = value;
            keys = tempKeys;
            values = tempValues;
        }
        public void Clear()
        {
            keys = new TKey[0];
            values = new TValue[0];
        }

        private int position = -1;
        public object Current => values[position];
        public bool MoveNext()
        {
            if (position < values.Length - 1)
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

        public IEnumerator GetEnumerator()
        {
            return this as IEnumerator;
        }
    }
}
