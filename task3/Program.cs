using System;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> beverages = new MyDictionary<string, string>();
            beverages.Add("coffee", "espresso");
            beverages.Add("coffee", "doppio");
            beverages.Add("coffee", "americano");
            beverages.Add("coffee", "ristretto");
            beverages.Add("coffee", "lungo");
            beverages.Add("tea", "black tea");
            beverages.Add("tea", "Green tea");

            foreach (string element in beverages)
                Console.WriteLine(element);
        }
    }
}
