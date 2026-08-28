namespace Abstracao
{
    internal class Time
    {
        public string NomeDoTime;
        public List<Jogador> ListaDeJogadores;
        public Time(string nomeDoTime)
        {
            NomeDoTime = nomeDoTime;
            ListaDeJogadores = new List<Jogador>();
        }

        public void AdicionarJogador(Jogador jogador)
        {
            ListaDeJogadores.Add(jogador);
        }

        public void ListarJogadores()
        {
            Console.WriteLine();
            Console.WriteLine($"Escalação do {NomeDoTime}:");
            foreach (Jogador jogador in ListaDeJogadores)
            {
                Console.WriteLine($"- {jogador.Nome} | Posição: {jogador.Posicao} | Camisa: {jogador.NumCamisa}");
            }
        }
    }
}
