
public class ContaCorrente : ContaBancaria
{
    public ContaCorrente(string nomeTitular, int agencia, int numero) : base(nomeTitular, agencia, numero, TipoContaEnum.Corrente)
    {
        if (this.TipoPessoa != TipoPessoaEnum.FISICA)
        {
            throw new ArgumentException("Só é possível criar uma conta corrente para uma pessoa física.");
        }
    }
    public override void Transferir(decimal valor, ContaBancaria contaDestino)
    {
        if (valor > 0 && this.Saldo >= valor)
        {
            this.Saldo -= valor;
            contaDestino.Depositar(valor);
        }
        else
        {
            Console.WriteLine("Não foi possível realizar a transferência. Verifique o saldo da conta.");
        }
    }
}

public class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(string nomeTitular, int agencia, int numero) : base(nomeTitular, agencia, numero, TipoContaEnum.Poupanca)
    {
        if (this.TipoPessoa != TipoPessoaEnum.FISICA)
        {
            throw new ArgumentException("Só é possível criar uma conta poupança para uma pessoa física.");
        }
    }
    public override void Transferir(decimal valor, ContaBancaria contaDestino)
    {
        if (valor > 0 && this.Saldo >= valor)
        {
            this.Saldo -= valor;
            contaDestino.Depositar(valor);
        }
        else
        {
            Console.WriteLine("Não foi possível realizar a transferência. Verifique o saldo da conta.");
        }
    }
}

public class ContaEmpresarial : ContaBancaria
{
    public ContaEmpresarial(string nomeTitular, int agencia, int numero) : base(nomeTitular, agencia, numero, TipoContaEnum.Empresarial)
    {
        if (this.TipoPessoa != TipoPessoaEnum.JURIDICA)
        {
            throw new ArgumentException("Só é possível criar uma conta empresarial para uma pessoa jurídica.");
        }
    }
}