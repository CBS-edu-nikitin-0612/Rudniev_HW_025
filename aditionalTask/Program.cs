using System;
using System.Collections;

namespace aditionalTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[20];
            for (int i = 0; i < intArray.Length; i++)
                intArray[i] = new Random().Next(0, 99);

            foreach (int element in intArray)
                Console.Write(element + " ");

            Console.WriteLine("\n" + new string('-', 60));

            foreach (int element in CollectionEvenNumbers(intArray))
                Console.Write(element + " ");
        }
        
        public static IEnumerable CollectionEvenNumbers(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++)
                if (intArray[i] % 2 == 0)
                    yield return intArray[i];
        }
    }
}
