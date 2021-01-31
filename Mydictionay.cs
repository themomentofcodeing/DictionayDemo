using System;
using System.Collections.Generic;
using System.Text;

namespace DictionayDemo
{
    class Mydictionay<K,V>
    {
        K[] Dizi1;
        V[] Dizi2;

        public Mydictionay()
        {
            Dizi1 = new K[0];
            Dizi2 = new V[0];

        }

        public void Add(K item1,V item2)
        {
            K[] YedekDizi1 = Dizi1;
            V[] YedekDizi2 = Dizi2;

            Dizi1 = new K[Dizi1.Length + 1];
            Dizi2 = new V[Dizi2.Length + 1];

            for (var i = 0; i < YedekDizi1.Length; i++)
            {
                Dizi1[i] = YedekDizi1[i];
            }
            Dizi1[YedekDizi1.Length] = item1;


            for (var i = 0; i < YedekDizi2.Length; i++)
            {
                Dizi2[i] = YedekDizi2[i];
            }
            Dizi2[YedekDizi2.Length] = item2;


        }

        public void Listele()
        {
            for (var i = 0; i <Dizi1.Length; i++)
            {
                Console.WriteLine(Dizi1[i] + "," + Dizi2[i]);
            }
            Console.WriteLine("*****************");
        }
    }
}
