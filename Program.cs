namespace Abstracao
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //criando o bagui
            Carro meuFusca = new Carro();
            meuFusca.Marca = "Volkswagen";
            meuFusca.Modelo = "Fusca";
            meuFusca.Cor = "Azul";
            meuFusca.Ano = 1978;

            Carro meuVizinho = new Carro();
            meuVizinho.Marca = "Fiat";
            meuVizinho.Modelo = "Uno";
            meuVizinho.Cor = "Prata";
            meuVizinho.Ano = 2010;

            Console.WriteLine("Informações do meu carro");
            meuFusca.ExibirInformacoes();

            Console.WriteLine("Informações do meu carro");
            meuVizinho.ExibirInformacoes();

            //EXER1

            Produto Caneta = new Produto();
            Caneta.Nome = "Caneta";
            Caneta.Preco = 3;
            Caneta.quantidadeEmEstoque = 4;

            Produto Caderno = new Produto();
            Caderno.Nome = "Caderno";
            Caderno.Preco = 10;
            Caderno.quantidadeEmEstoque = 3;

            Console.WriteLine("Informações do meu produto");
            Caneta.ExibirInformacoes();

            Console.WriteLine("Informações do meu produto");
            Caderno.ExibirInformacoes();
        }
    }
}
