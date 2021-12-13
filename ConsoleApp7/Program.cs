using System;

namespace Lab2
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        const int N = 10;
        int[] vector = new int[N];

        Console.WriteLine("Масив");

        for (int i = 0; i < N; i++)
        {
            vector[i] = random.Next(1, 9);
            Console.Write("{0} ", vector[i]);
        }

        Console.WriteLine("\nПарні");


        for (int i = 0; i < N; i++)
        {
            if (vector[i] % 2 == 0)
            {
                Console.Write("{0} ", vector[i]);
            }
        }

        Console.WriteLine("\nНепарні");

        for (int i = 0; i < N; i++)
        {
            if (vector[i] % 2 != 0)
            {
                Console.Write("{0} ", vector[i]);
            }
        }
    }
}

