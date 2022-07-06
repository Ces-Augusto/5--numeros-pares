using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5__numeros_pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Precione qualque tecla para ver todos os numeros pares entre 1 e 100\n");
            Console.ReadKey();

            for (int n1 = 1; n1<=100;n1++) 
            {
                if (n1 % 2 == 0)
                {
                    Console.WriteLine("\t\t\t\t" + n1);
                }
                
                
            }
            Console.ReadKey();
        }
    }
}
