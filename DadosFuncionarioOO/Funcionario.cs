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

        public Funcionario() {
            nome = "";
            salarioBruto = 0;
            imposto = 0;
        }

        public Funcionario(string nome) {
            this.nome = nome;
        }

        public Funcionario(string nome, double salarioBruto) : this (nome) {
            this.salarioBruto = salarioBruto;
        }

        public Funcionario(string nome, double salarioBruto, double imposto) : this(nome, salarioBruto) {
            this.imposto = imposto;
        }
        /*public double CalcularAumento(double aumento)
        {
            return salarioBruto * (aumento / 100 + 1);
        }*/
    }
}
