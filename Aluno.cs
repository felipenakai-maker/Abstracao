using System.Security.Cryptography.X509Certificates;

namespace Abstracao
{
    internal class Aluno
    {
        public string Nome;
        public int Matricula;
        public double Nota1;
        public double Nota2;

        public void CalcularMedia()
        {
            double Media = (Nota1 + Nota2) / 2;
            Console.WriteLine($"A media final do aluno {Nome} foi de {Media}");
        }
    }
}
