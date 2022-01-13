using System;

namespace _1_suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sum;
            sum = 0;
            Console.WriteLine("Scrieti un nr: ");
            a = int.Parse(Console.ReadLine());
            int[] numere = new int[a];
            Console.WriteLine("Scrieti {0} nr: ", a);
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }
            foreach(var nr in numere)
            {
                sum += nr;
            }
            Console.WriteLine(sum);
        }
    }
}
