using System;

namespace _2_pozitie
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b,k;
            b = 0;

            Console.WriteLine("Scrieti un nr pentru nr. de elemente si un nr. k: ");
            a = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            int[] numere = new int[a];
            Console.WriteLine("Scrieti {0} nr: ", a);
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }
            int index = Array.IndexOf(numere, k);
            Console.WriteLine("Indexul " + index);
            if (index == -1)
            {
                Console.WriteLine(-1);
            }
           
        }
    }
}
