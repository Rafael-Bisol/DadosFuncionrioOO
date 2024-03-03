using System;

namespace DadosFuncionarioOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dados do funcionario");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Salário Bruto: ");
            double salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Salário Líquido: ");
            double imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("Porcentagem do Aumento: ");

            double salarioLiquido = salarioBruto - imposto;

            Console.WriteLine("O funcionário " + nome + " receberá " + salarioLiquido.ToString("C"));

            double aumento = double.Parse(Console.ReadLine()) / 100;
            salarioBruto *= aumento + 1;
            salarioLiquido = salarioBruto - imposto;

            Console.WriteLine("Considerando o aumento os novos valores para o funcionário " + nome + " serão:" +
                "\nSalário Bruto: " + salarioBruto + "\nSalario Líquido: " + salarioLiquido);
        }
    }
}
