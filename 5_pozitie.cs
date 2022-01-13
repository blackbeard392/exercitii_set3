using System;

namespace _5_pozitie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,k, e;
            Console.Write("Scrieti un nr: ");
            a = int.Parse(Console.ReadLine());
            int[] numere = new int[a];
            Console.Write("Scrieti {0} nr care vor fi valorile vectorului ", a);
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Scrieti o pozitie in vector intre 0 si {0}",a-1);
            k = int.Parse(Console.ReadLine());
            if(k <= a)
            {
                Console.WriteLine("Scrieti o valoare e");
                e = int.Parse(Console.ReadLine());
                numere[k] = e;
                int index = Array.IndexOf(numere,numere[k]);
                Console.WriteLine("Valoare {0} este pe pozitia {1}",e,index);
            }
            else
            {
                Console.WriteLine("Ati introdus o valoare mai mare decat pozitiile din vector");
            }
        }
    }
}
