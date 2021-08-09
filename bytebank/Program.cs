using System;

namespace bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            ContaCorrente conta = new ContaCorrente(84712540,
                                             1010);
            ContaCorrente conta2 = new ContaCorrente(81712540,
                                             1011);
            Console.WriteLine(ContaCorrente.ObterTotalDeContasCriadas());
            Console.ReadLine();
        }
    }
}
