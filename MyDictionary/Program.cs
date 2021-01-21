using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string> names = new MyDictionary<string>();
            names.Add("Ürem");
            names.Add("Sancaktutan");


            foreach (var name in names.List)
            {
                Console.WriteLine("Added! : " + name);
            }

            Console.ReadLine();
        }
    }
}
