using System;

namespace _4_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,count,b;
            count = 0;
            b = 0;
            Console.WriteLine("Scrieti un nr: ");
            a = int.Parse(Console.ReadLine());
            int[] numere = new int[a];
            Console.WriteLine("Scrieti {0} nr: ", a);
            for (int i = 0; i < numere.Length; i++)
            {
                numere[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(numere);
           for(int c = 0; c < numere.Length; c++)
            {
                if(numere[c] == numere[0] || numere[c] == numere[a-1])
                {
                    count += 1;
                }
            }
            do
            {
                Console.WriteLine("Cea mai mica valoare este {0}, iar cea mai mare este {1}",numere[0],numere[a-1]);
                Console.WriteLine("Ele apar de {0} ori", count);

                b++;
            } while (b < 1);
        }
    }
}
