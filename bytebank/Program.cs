using System;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Cliente gabriela = new Cliente();

            gabriela.nome = "Gabriela Costa";
            gabriela.profissão = "Garçonete";
            gabriela.cpf = "43256287820";

            ContaCorrente conta = new ContaCorrente();
            conta.Titular = gabriela;
            conta.saldo = 400;
            conta.agencia = 563;
            conta.numero = 56632;
            Console.WriteLine(conta.Titular.nome);

            Console.ReadLine();
        }
    }
}
