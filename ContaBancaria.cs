using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Transactions;

namespace SistemaBancario
{
    class ContaBancaria
    {
        private int _numeroConta;
        private string _titular;
        private double _saldo;

        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public double Saldo
        {
            get { return _saldo; }
            protected set { _saldo = value; }
        }

        public ContaBancaria(int numeroConta, string titular, double saldoInicial)
        {
            this._numeroConta = numeroConta;
            this._titular = titular;
            this._saldo = saldoInicial;
        }

        public virtual void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
            else
            {
                Console.WriteLine("O valor do depósito deve ser positivo.");
            }
        }

        public virtual void Sacar(double valor)
        {
            if (valor > 0 && valor <= _saldo)
            {
                _saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente ou valor inválido!");
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"{GetType().Name} - {Titular} | Saldo: {Saldo:C}");
        }
    }
}
