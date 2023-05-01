using System;


    internal class ContaEmpresarial : ContaBancaria
{
    public decimal LimiteEmprestimo { get; private set; }
    public decimal TaxaJuros { get; private set; }
    public decimal ValorUsado { get; private set; }
    public bool PossuiEmprestimo { get; private set; }
    public string CNPJ { get; private set; }

    public ContaEmpresarial(int numero, int agencia, Cliente cliente, decimal limiteEmprestimo,
       decimal taxaJuros, string cnpj) : base(numero, agencia, cliente)
    {
        LimiteEmprestimo = limiteEmprestimo;
        TaxaJuros = taxaJuros;
        CNPJ = cnpj;

        if (cliente.TipoPessoa != tipoPessoa.JURIDICA)
        {
            throw new ArgumentException("Cliente deve ser do tipo Jurídico!");
        }
    }
    public void FazerEmprestimo(decimal valor)
    {
        if (valor <= 0)
        {
            Console.WriteLine("O valor precisa ser maior que 0");
            return;

        }

        if (PossuiEmprestimo)
        {
            Console.WriteLine("Você ja possui um empréstimo aberto!");
            return;

        }

        if (valor > LimiteEmprestimo)
        {
            Console.WriteLine("O valor ultrapassa o limite de empréstimo disponível");
            return;
        }
        PossuiEmprestimo = true;
        base.Depositar(valor);
        ValorUsado = valor;
        Console.WriteLine($"Empréstimo de R$ {valor} concedido com sucesso");
    }
    public void PagarEmprestimo()
    {
        decimal total = ValorUsado + (ValorUsado * TaxaJuros / 100);
        if (total > Saldo)
        {
            Console.WriteLine("saldo insuficiente para o pagamento");
            return;

        }
        Sacar(total);
        PossuiEmprestimo = false;
        ValorUsado = 0;
        Console.WriteLine($"Emprestimo de R$ {total} pago com sucesso");

    }

    public override void Sacar(decimal valor)
    {
        valor = valor + 1;
        base.Sacar(valor);
    }
    public override void Transferir(ContaBancaria conta, decimal valor)
    {
        valor = valor + 0.50M;
        base.Transferir(conta, valor);
    }
