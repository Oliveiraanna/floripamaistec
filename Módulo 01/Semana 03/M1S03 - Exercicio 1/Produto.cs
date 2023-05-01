namespace M1S03
{
    public class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public Produto(string nome, double preço, int quantidade)
        {
            this.nome = nome;
            this.preco = preço;
            this.quantidade = quantidade;
        }
        public Produto()
        {
            nome = "Sem nome";
            preco = 0;
            quantidade = 0;
        }

    }
}