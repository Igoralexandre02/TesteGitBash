using System;

namespace TesteGitBash
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("");

            Console.Write("Qual seu nome? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Bom dia, " + nome);

            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("");
            try
            {
                Console.WriteLine($"{nome}, informe dois número inteiro: ");
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                int resultado = n1 / n2;
                Console.WriteLine("A divisão dos números é: " + resultado);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Erro! " + e.Message);
            }
        }
    }
}
