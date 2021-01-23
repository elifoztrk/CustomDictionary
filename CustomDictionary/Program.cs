using System;

namespace CustomDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
                MyDictionary<int, string> myDic = new MyDictionary<int, string>();
                myDic.Add(1, "Elma");
                myDic.Add(2,"Armut");

        

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
