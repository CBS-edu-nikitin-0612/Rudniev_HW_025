using System;
using System.Collections;

namespace task4
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> intArray = new MyList<int>();
            for (int i = 0; i < 10; i++)
                intArray.Add(new Random().Next(0, 99));

            int[] array = intArray.GetArray<int>();

            foreach (int element in array)
                Console.Write(element + "  ");
        }
    }

    static class extendingClass
    {
        public static T[] GetArray<T>(this IEnumerable list)
        {
            MyList<T> myList = list as MyList<T>;
            T[] array = new T[myList.Count];
            for (int i = 0; i < myList.Count; i++)
                array[i] = myList[i];
            return array;
        }
    }
}
