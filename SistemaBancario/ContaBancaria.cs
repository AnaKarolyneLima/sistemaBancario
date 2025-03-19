using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace SistemaBancario
{
     class ContaBancaria
    {
       private int _numeroConta;
       private string _titular { get; set; }
       private double _saldo { get; set; }

        public ContaBancaria (int numeroConta, string titular, double saldoInicial)
        {
            this._numeroConta = numeroConta;
            this._titular = titular;
            this._saldo = saldoInicial;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;

        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Seu saldo: {_saldo}");
        }

        public void Sacar(double valor)
        {
            if (valor <= _saldo && valor > 0)
            {
                _saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saldo Insuficiente ou valor inválido! ");

            }
        }
    }

    
}

