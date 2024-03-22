using System;

namespace DadosFuncionarioOO
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salarioBruto, imposto;

            Console.WriteLine("Dados do funcionario");
            Console.Write("Nome: ");
            nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Salário Líquido: ");
            imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("Porcentagem do Aumento: ");

            Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);

            Console.WriteLine("O funcionário " + funcionario.nome + " receberá " + funcionario.CalcularSalarioLiquido().ToString("C"));

            Console.Write("Digite o aumento do funcionário: ");
            funcionario.CalcularAumento(double.Parse(Console.ReadLine()));

            Console.WriteLine("Considerando o aumento os novos valores para o funcionário " + funcionario.nome + " serão:" +
                "\nSalário Bruto: " + funcionario.salarioBruto + "\nSalario Líquido: " + funcionario.CalcularSalarioLiquido().ToString("C"));
        }
    }
}
