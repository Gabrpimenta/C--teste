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

  public static void Matriz(string[] args)
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

// Questão 04 - Fábrica de Automóveis

  abstract class Carro
  {
    public int NumeroChassi { get; set; }
    public int NumeroMotor { get; set; }
    public double CustoProducao { get; set; }

    public abstract double CalcularImposto();
    public virtual double CalcularCustoVenda()
    {
      double imposto = CalcularImposto();
      double lucro = CustoProducao * 0.25;
      return CustoProducao + imposto + lucro;
    }
  }

  class CarroFlex : Carro
  {
    public int NumeroPortas { get; set; }
    public double Cilindrada { get; set; }

    public override double CalcularImposto()
    {
      return CustoProducao * 0.2;
    }
  }
  class CarroDiesel : Carro
  {
    public double CapacidadeCarga { get; set; }
    public double VolumeCacamba { get; set; }

    public override double CalcularImposto()
    {
      return CustoProducao * 0.3;
    }
  }
  class CarroEletrico : Carro
  {
    public double Potencia { get; set; }
    public double DuracaoBateria { get; set; }

    public override double CalcularImposto()
    {
      return CustoProducao * 0.1;
    }
  }

  static void Main(string[] args)
  {
      CarroFlex carroFlex = new CarroFlex()
      {
        NumeroChassi = 1,
        NumeroMotor = 100,
        NumeroPortas = 4,
        Cilindrada = 2.0,
        CustoProducao = 30000.0
      };
      Console.WriteLine("Custo de venda do carro flex: " + carroFlex.CalcularCustoVenda());

      CarroDiesel carroDiesel = new CarroDiesel()
      {
        NumeroChassi = 2,
        NumeroMotor = 200,
        CapacidadeCarga = 1000.0,
        VolumeCacamba = 5.0,
        CustoProducao = 50000.0
      };
      Console.WriteLine("Custo de venda do carro diesel: " + carroDiesel.CalcularCustoVenda());

      CarroEletrico carroEletrico = new CarroEletrico()
      {
        NumeroChassi = 3,
        NumeroMotor = 300,
        Potencia = 200.0,
        DuracaoBateria = 100.0,
        CustoProducao = 70000.0
      };
      Console.WriteLine("Custo de venda do carro elétrico: " + carroEletrico.CalcularCustoVenda());
    }

}