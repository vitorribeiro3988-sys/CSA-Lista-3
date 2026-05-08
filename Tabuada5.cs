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
            int n = 1;
            while (n <= 10)
            {
                Console.WriteLine("5 x " + n + " = " + (5 * n));
                n++;
            }
        }
    }
}
