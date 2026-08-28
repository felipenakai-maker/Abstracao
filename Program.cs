namespace Abstracao
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno Joao = new Aluno();
            Console.WriteLine("Digite seu nome");
            Joao.Nome = Console.ReadLine();
            Console.WriteLine("Digite sua matricula");
            Joao.Matricula = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua nota");
            Joao.Nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite sua nota");
            Joao.Nota2 = Convert.ToDouble(Console.ReadLine());

            Joao.CalcularMedia();
        }
    }
}
