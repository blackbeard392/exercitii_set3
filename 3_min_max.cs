using System;

namespace _3_min_max
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
                   
            Console.WriteLine("Scrieti un nr: ");
            a = int.Parse(Console.ReadLine());
            int[] numere = new int[a];
            int[] numere2 = new int[a];
            Console.WriteLine("Scrieti {0} nr: ", a);
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
                
            }
            Array.Copy(numere,numere2,a);
            Array.Sort(numere2);
            int mic = Array.IndexOf(numere, numere2[0]);
            int mare =  Array.IndexOf(numere, numere2[a-1]);
            Console.WriteLine("Indexul celui mai mic nr: " + mic);
            Console.WriteLine("Indexul celui mai mare nr: " + mare);
        }
    }
}
