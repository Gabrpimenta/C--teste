using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a posição desejada na sequência de Fibonacci: ");
            int posicao = int.Parse(Console.ReadLine());
            
            int numero = Fib(posicao);

            Console.WriteLine($"O número da sequência de Fibonacci na posição {posicao} é {numero}");

            Console.ReadKey();
        }
        
        static int Fib(int posicao)
        {
            if (posicao == 0)
                return 0;
            else if (posicao == 1)
                return 1;
            else
                return Fib(posicao - 1) + Fib(posicao - 2);
        }
    }
}