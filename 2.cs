using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random n = new Random(5);
            int[] vet = new int[5];
            int m = int.MaxValue, t=0, vn;
            for(int i = 0; i < 5; i++)
            {
                /*Console.WriteLine("Dê um valor qualquer");
                vet[i] = int.Parse(Console.ReadLine());*/
                vet[i] = n.Next();
                Console.WriteLine("Números:" + vet[i] + "\n");
                if(vet[i] < m)
                {
                    m = vet[i];
                    t = i;
                }
            }
            vn = vet[0];
            vet[0] = m;
            vet[t] = vn;
            Console.WriteLine("Elementos do arranjo: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(vet[i] + " ");
            }
            Console.ReadLine();
        }
    }
}
