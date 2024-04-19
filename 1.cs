using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            int[] vet = new int[20];
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Dê o valor dos vetores");
                vet[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Dê o valor que deseja sem encontrado");
            n = int.Parse(Console.ReadLine());
            for(int i = 0; i < 20; i++)
            {
                if(vet[i] == n)
                {
                    Console.WriteLine("A posição do vetor do valor informado é: " + i);
                }
            }
            Console.ReadLine();
        }
    }
}
