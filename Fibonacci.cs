using System;

class Program
{
    static void Main()
    {
        int[] fibonacci = new int[30];

        fibonacci[0] = 1;
        fibonacci[1] = 1;

        for (int i = 2; i < 30; i++)
        {
            fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
        }
        for (int i = 0; i < 30; i++)
        {
            Console.Write(fibonacci[i] + " ");
        }

        Console.WriteLine();
    }
}
