namespace Abstracao
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int quantidadeEmEstoque;
        public void ExibirInformacoes()
        {
            Console.WriteLine($"{Nome}, Custa: {Preco}, Estoque: {quantidadeEmEstoque}");
        }

    }
}
