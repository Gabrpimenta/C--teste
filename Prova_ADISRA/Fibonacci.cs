using System;

public class Program
{
  // Questão 01 - Fibonacci
  public static void Fibonacci(string[] args)
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

  // Questão 02 - Matriz

  public static void Main(string[] args)
  {
    int[,] matriz = new int[3, 3]
    {
      {
        1, 2, 3
      },
      { 3, 5, 6 },
      { 7, 8, 9 },
    };
    int pares = 0;
    int impares = 0;

    int linhas = matriz.GetLength(0);
    int colunas = matriz.GetLength(1);

    for (int i = 0; i < linhas; i++)
    {
      for (int j = 0; j < colunas; j++)
      {
        if (matriz[i, j] % 2 == 0)
        {
          pares++;
        }
        else
        {
          impares++;
        }
      }
    }

    if (pares > impares)
    {
      Console.Write("Pares");
    }
    else if (impares > pares)
    {
      Console.Write("Impares");
    }
    else
    {
      Console.Write("Iguais");
    }
  }
}