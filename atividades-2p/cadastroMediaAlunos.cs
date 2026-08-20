Console.WriteLine("Quantos alunos deseja cadastrar? ");
int quantidade = int.Parse(Console.ReadLine());

string[] nomes = new string[quantidade];
double[] nota1 = new double[quantidade];
double[] nota2 = new double[quantidade];
double[] media = new double[quantidade];

for (int i = 0; i < quantidade; i++)
{
    Console.WriteLine($"\nAluno {i + 1}");

    Console.WriteLine("Nome: ");
    nomes[i] = Console.ReadLine();

    Console.WriteLine("Primeira nota: ");
    nota1[i] = double.Parse(Console.ReadLine());

    Console.Write("Segunda nota: ");
    nota2[i] = double.Parse(Console.ReadLine());

    media[i] = (nota1[i] + nota2[i]) / 2;

    Console.WriteLine($"Média: {media[i]:F2} - ");

    if (media[i] >= 7)
    {
        Console.WriteLine("Aprovado");
    }
    else if (media[i] >= 5)
    {
        Console.WriteLine("Recuperação");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
}
