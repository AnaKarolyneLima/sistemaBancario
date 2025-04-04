using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class ContaCorrente : ContaBancaria
    {
        private const double TAXA_SAQUE = 5.0;

        public ContaCorrente(int numeroConta, string titular, double saldoInicial)
            : base(numeroConta, titular, saldoInicial) { }

        public override void Sacar(double valor)
        {
            double valorTotal = valor + TAXA_SAQUE;
            if (valor > 0 && valorTotal <= Saldo)
            {
                Saldo -= valorTotal;
                Console.WriteLine($"Saque de {valor:C} realizado com sucesso! Taxa de {TAXA_SAQUE:C} cobrada.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido!");
            }
        }
    }
}