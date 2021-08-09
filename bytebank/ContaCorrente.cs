public class ContaCorrente
{
    public Cliente Titular { get; set; }
    public int Numero { get; set; }
    private int Agencia { get; set; }
    private double _saldo = 100;

    private static int TotalDeContasCriadas { get; private set; }
    public static int ObterTotalDeContasCriadas()
    {
        return TotalDeContasCriadas;
    }
    public double Saldo
    {
        get
        {
            return _saldo;
        }
        set
        {
            if (value < 0)
            {
                return;
            }

            _saldo = value;
        }
    }

    public ContaCorrente(int agencia, int numero)
    {
        Agencia = agencia;
        Numero = numero;
        TotalDeContasCriadas++;
    }
    public bool Sacar(double valor)
    {
        if (_saldo < valor)
        {
            return false;
        }

        _saldo -= valor;
        return true;
    }

    public void Depositar(double valor)
    {
        _saldo += valor;
    }


    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (_saldo < valor)
        {
            return false;
        }

        _saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}