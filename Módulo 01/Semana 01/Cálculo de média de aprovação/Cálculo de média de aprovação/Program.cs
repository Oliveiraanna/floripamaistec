
class Program
{
    static void Main()
    {
        <string> nomes = new <string>();
        <decimal> medias = new <decimal>();
        
        // recebe o nome e as médias dos alunos

        Console.WriteLine("Digite o nome e a média final de cinco alunos:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Nome do Aluno {i + 1}: ");
            string nome = Console.ReadLine();
            Console.Write($"Nota do Aluno {i + 1}: ");
            decimal media = decimal.Parse(Console.ReadLine());
            nomes.Add(nome);
            medias.Add(media);
        }
        // verifica as médias e exibe se o aluno está aprovado ou não

        Console.WriteLine("Status da situação dos alunos:");
        for (int i = 0; i < 5; i++)
        {
            string nome = nomes[i];
            decimal media = medias[i];
            string situacao = (media >= 6) ? "APROVADO" : "REPROVADO";
            Console.WriteLine($"{nome}: {situacao}");
        }
    }
}
