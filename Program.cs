namespace NotaAluno
{
    class Program
    {
        static void Main()
        {
            Console.Write("Digite a nota do aluno: ");
            double nota = Convert.ToDouble(Console.ReadLine());

            if (nota < 5)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if (nota >= 5 && nota < 7)
            {
                Console.WriteLine("Aluno em exame.");
            }
            else
            {
                Console.WriteLine("Aluno aprovado.");
            }

            Console.ReadKey();
        }
    }
}
