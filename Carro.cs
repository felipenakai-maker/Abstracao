using System.Globalization;

namespace Abstracao
{
    public class Carro
    {
        //ATRIBUTOS  (CARACTERISTICAS)
        
        public string Marca;
        public string Modelo;
        public string Cor;
        public int Ano;

        //Metodos (Comportamento)
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo}");
            Console.WriteLine($"Cor: {Cor}, Ano: {Ano}");
        }

    }
}
