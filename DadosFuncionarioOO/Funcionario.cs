using System;

namespace DadosFuncionarioOO
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto, imposto;

        public double CalcularSalarioLiquido()
        {
            return salarioBruto - imposto;
        }

        public void CalcularAumento(double aumento)
        {
            salarioBruto *= aumento / 100 + 1;
        }

        /*public double CalcularAumento(double aumento)
        {
            return salarioBruto * (aumento / 100 + 1);
        }*/
    }
}
