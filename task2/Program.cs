using System;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> intArray = new MyList<int>();
            for (int i = 0; i < 10; i++)
                intArray.Add(new Random().Next(0, 99));

            foreach(int element in intArray)
                Console.Write(element + "  ");
        }
    }
}
