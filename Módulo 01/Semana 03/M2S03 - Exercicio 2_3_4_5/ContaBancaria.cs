

public class ContaBancaria
{
    public string nomeTitular;
    public int agencia;
    public int numero;
    public double saldo;
    public TipoContaEnum TipoConta;

    public ContaBancaria(string nomeTitular, int agencia, int numero, TipoContaEnum TipoConta)
    {
        this.nomeTitular = nomeTitular;
        this.agencia = agencia;
        this.numero = numero;
        this.TipoConta = TipoConta;
        this.saldo = 0;
    }

    public ContaBancaria(string nomeTitular, TipoContaEnum TipoConta)
    {
        this.nomeTitular = nomeTitular;
        this.agencia = 999;
        this.numero = 999;
        this.TipoConta = TipoConta;
        this.saldo = 0;
    }

    public void Deposito(double valor)
    {
        this.saldo += valor;
    }

    public void Saque(double valor)
    {
        if (valor <= this.saldo)
        {
            this.saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public void Transferencia(ContaBancaria contaDestino, double valor)
    {
        if (valor <= this.saldo)
        {
            this.saldo -= valor;
            contaDestino.saldo += valor;
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public void PrintSaldo()
    {
        Console.WriteLine("Conta: " + this.numero + " Saldo: " + this.saldo);
    }

    public void Relatorio()
    {
        Console.WriteLine("Titular da conta: " + this.nomeTitular);
        Console.WriteLine("Agência: " + this.agencia);
        Console.WriteLine("Conta: " + this.numero);
        Console.WriteLine("Tipo da conta: " + this.TipoConta);
        Console.WriteLine("Saldo: " + this.saldo);
    }
}