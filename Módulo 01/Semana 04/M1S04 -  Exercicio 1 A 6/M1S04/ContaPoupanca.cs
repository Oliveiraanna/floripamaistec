using System;

internal class ContaPoupanca : ContaBancaria
{
    public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
    {
        if (cliente.TipoPessoa != tipoPessoa.FISICA)
        {
            throw new ArgumentException("Cliente deve ser do tipo física!");
        }
    }
    public override void Sacar (decimal valor)
    {
        valor = valor + 0.10M;
        base.Sacar(valor);
    }
    public override void Transferir (ContaBancaria conta, decimal valor)
    {
        valor = valor + 0.05M;
        base.Transferir (conta, valor);
    }
}

// Semana 04 - Exercício 3:
public class ContaPoupanca : ContaBancaria
    {
        public ContaPoupanca(int numero, int agencia, Cliente cliente) : base(numero, agencia, cliente)
        {
            if (cliente.TipoPessoa != TipoPessoaEnum.FISICA)
            {
                throw new ArgumentException("Cliente precisa ser do tipo física!");
            }
        }

        // Semana 04 - Exercício 6:
        public override void Sacar (decimal valor)
        {
            valor += 0.10M;
            base.Sacar(valor);
        }

        public override void Transferir (ContaBancaria conta, decimal valor)
        {
            valor += 0.05M;
            base.Transferir(conta, valor);
        }
    }
