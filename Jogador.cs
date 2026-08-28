namespace Abstracao
{
    internal class Jogador
    {
        public string Nome;
        public string Posicao;
        public int NumCamisa;

        public Jogador(string nome, string posicao, int numeroCamisa)
        {
            Nome = nome;
            Posicao = posicao;
            NumCamisa = numeroCamisa;
        }
    }
}
