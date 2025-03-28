using System.Security.Cryptography.X509Certificates;

namespace SistemaBancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cc = new ContaCorrente(123, "João Silva", 1000);
            cc.Depositar(500);
            cc.Sacar(200);
            cc.ExibirSaldo();

            ContaPoupanca cp = new ContaPoupanca(456, "Maria Souza", 2000);
            cp.Depositar(1000);
            cp.Sacar(500);
            cp.ExibirSaldo();
        }
    }
}
