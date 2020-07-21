using System;
using System.Globalization;

namespace MaiorSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com a quantidade total de funcionários: ");
            int qtd = int.Parse(Console.ReadLine());

            Funcionario maiorSalario = new Funcionario();
            maiorSalario.salario = 0.0;

            for (int i = 0; i < qtd; i++)
            {
                Funcionario f = new Funcionario();

                Console.WriteLine("Informe o nome do funcionário: ");
                f.nome = Console.ReadLine();

                Console.WriteLine("Informe a idade do funcionário: ");
                f.idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Informe o salário do funcionário: ");
                f.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (f.salario > maiorSalario.salario)
                {
                    maiorSalario = f;
                }
            }

            Console.WriteLine("Maior salário: {0}", maiorSalario.Apresentacao());
        }
    }
}
