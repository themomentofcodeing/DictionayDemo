using System;

namespace DictionayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Mydictionay<string, int> mydictionay = new Mydictionay<string, int>();

            mydictionay.Add("elma",100);
            mydictionay.Listele();

            mydictionay.Add("elma", 200);
            mydictionay.Add("armut", 50);
            mydictionay.Add("kivi", 20);
            mydictionay.Add("muz", 10);

            mydictionay.Listele();


            Console.ReadLine();
        }
    }
}
