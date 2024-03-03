using System;

namespace DadosFuncionarioOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Dados do funcionario");
            Console.Write("Nome: ");
            funcionario.nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            funcionario.salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Salário Líquido: ");
            funcionario.imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("Porcentagem do Aumento: ");

            Console.WriteLine("O funcionário " + funcionario.nome + " receberá " + funcionario.CalcularSalarioLiquido().ToString("C"));

            Console.Write("Digite o aumento do funcionário: ");
            funcionario.CalcularAumento(double.Parse(Console.ReadLine()));

            Console.WriteLine("Considerando o aumento os novos valores para o funcionário " + funcionario.nome + " serão:" +
                "\nSalário Bruto: " + funcionario.salarioBruto + "\nSalario Líquido: " + funcionario.CalcularSalarioLiquido().ToString("C"));
        }
    }
}
