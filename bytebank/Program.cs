using System;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("rodando");
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.Titular = "Gabriela";
            contaDaGabriela.agencia = 365;
            contaDaGabriela.numero = 8636365;
            contaDaGabriela.saldo = 100;

            Console.WriteLine(contaDaGabriela.Titular);
            Console.WriteLine("Agência: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero: "+contaDaGabriela.numero);
            Console.WriteLine("Saldo: R$" + contaDaGabriela.saldo);


            contaDaGabriela.Sacar(65.00);
            Console.WriteLine("Saldo: R$" + contaDaGabriela.saldo);
            contaDaGabriela.Sacar(15.00);
            Console.WriteLine("Saldo: R$" + contaDaGabriela.saldo);
            contaDaGabriela.Sacar(65.00);
            Console.WriteLine("Saldo: R$" + contaDaGabriela.saldo);
            Console.ReadLine();
        }
    }
}
