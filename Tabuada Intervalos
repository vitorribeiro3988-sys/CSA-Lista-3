using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valor_Positivo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Valor: ");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);

            Console.Write("Começo: ");
            int a = int.Parse(Console.ReadLine());

            int b;
            do
            {
                Console.Write("Fim: ");
                b = int.Parse(Console.ReadLine());
            } while (b <= a);

            for (int c = b; c >= a; c--)
            {
                Console.WriteLine(n + " x " + c + " = " + (n * c));
            }
        }
    }
}
