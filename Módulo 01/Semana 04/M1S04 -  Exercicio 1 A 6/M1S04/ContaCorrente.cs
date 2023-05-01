using System;


public class ContaCorrente : ContaBancaria
{
    public ContaCorrente(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
    {
        if (cliente.TipoPessoa != tipoPessoa.FISICA)
        {
            throw new ArgumentException("Cliente precisa ser do tipo física!");
        }
    }
    public override void Sacar(decimal valor)
    {
        valor = valor + 0.50M;
        base.Sacar(valor);
    }
    public override void Transferir(ContaBancaria conta, decimal valor)
    {
        valor = valor + 0.25M;
        base.Transferir(conta, valor);
    }
}