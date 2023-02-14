namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {

            
            ContaBancaria conta = new ContaBancaria();

            conta.Numero = 12345;
            conta.Agencia = 6789;
            conta.NomeDoTitular = "Anna Oliveira";
            conta.TipoConta = TipoContaEnum.CORRENTE;

            // Solicitando valor de depósito
            Console.WriteLine("Digite o valor a ser depositado:");
            decimal deposito = decimal.Parse(Console.ReadLine());

            // testando metodo depositar
            conta.Depositar(deposito);

            // Solicitando valor de saque
            Console.WriteLine("Digite o valor a ser sacado:");
            decimal saque = decimal.Parse(Console.ReadLine());

            // testando metodo sacar 
            conta.Sacar(saque);

            // testando método exibir saldo
            conta.ExibirSaldo();

            Console.ReadLine();
        }
    }

    // M1S2 Exercicio 03
    public class ContaBancaria
    {
        public int Numero;
        public int Agencia;
        public string NomeDoTitular;
        public TipoContaEnum TipoConta;
        private decimal Saldo = 0 ;


        // M1S2 Exercicio 04
        public void Depositar(decimal valor)
        {
            Saldo += valor;
        }
        // M1S2 Exercicio 05
        public void Sacar(decimal valor)
        {
            Saldo -= valor;
        }
        // M1S2 Exercicio 06
        public void ExibirSaldo()
        {
            Console.WriteLine("Saldo: " + Saldo);
        }
    }
    // TipoContaEnum
    public enum TipoContaEnum
    {
        CORRENTE,
        POUPANCA
    }
}