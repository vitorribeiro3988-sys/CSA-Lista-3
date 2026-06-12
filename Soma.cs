using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int soma = 0;
            for (int n=1; n <= 100;  n++) 
            { soma = soma + n; }
            Console.WriteLine(soma);
          
        }
    }
}
