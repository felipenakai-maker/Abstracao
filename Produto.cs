namespace Abstracao
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int quantidadeEmEstoque;

        public Produto(string nome, double preco, int qtd)
        {
            Nome = nome;
            Preco = preco;
            quantidadeEmEstoque = qtd;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"{Nome}, Custa: {Preco}, Estoque: {quantidadeEmEstoque}");
        }

    }
}
