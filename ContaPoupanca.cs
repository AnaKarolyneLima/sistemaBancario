using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario
{
    class ContaPoupanca : ContaBancaria
    {
        private const double BONUS_DEPOSITO = 0.005;

        public ContaPoupanca(int numeroConta, string titular, double saldoInicial)
            : base(numeroConta, titular, saldoInicial) { }

        public override void Depositar(double valor)
        {
            if (valor > 0)
            {
                double bonus = valor * BONUS_DEPOSITO;
                Saldo += valor + bonus;
                Console.WriteLine($"Depósito de {valor:C} realizado! Bônus de {bonus:C} aplicado.");
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }
    }
}