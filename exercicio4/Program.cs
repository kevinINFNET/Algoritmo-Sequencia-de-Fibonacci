using System;

class Programa
{
    static void Main()
    {
        Console.Write("Digite um número inteiro por favor: ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
        {
            MostrarSequenciaFibonacci(n);
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, entre com um número inteiro ");
        }
    }

    static void MostrarSequenciaFibonacci(int n)
    {
        if (n == 0)
        {
            Console.WriteLine("Não há números na sequência de Fibonacci.");
            return;
        }

        long a = 0, b = 1;

        Console.Write("Sequência de Fibonacci: ");
        for (int i = 1; i <= n; i++)
        {
            if (i == 1)
            {
                Console.Write(a);
            }
            else if (i == 2)
            {
                Console.Write(", " + b);
            }
            else
            {
                long c = a + b;
                Console.Write(", " + c);
                a = b;
                b = c;
            }
        }
        Console.WriteLine();
    }
}
