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

/* Questão 03 - Resultado do programa abaixo:
 
{
if (n == 1) return 1;
if (n % 2 == 0) return ff( n/2);
return ff( (n-1)/2) + ff( (n+1)/2);
}
void main() {
printf( "%d", ff(7));
return;
}

O programa acima é uma função recursiva que recebe um inteiro n e retorna um valor inteiro.

Se n for igual a 1, a função retorna 1.
Se n for par, a função chama a si mesma com o parâmetro n/2.
Se n for ímpar, a função chama a si mesma com os parâmetros (n-1)/2 e (n+1)/2 e retorna a soma dos valores retornados por essas chamadas recursivas.
No main() do programa, a função ff() é chamada com o parâmetro 7 e o resultado retornado é impresso na tela. O resultado dessa chamada é 7, ou seja, o programa imprime o número 7 na tela.

*/
}