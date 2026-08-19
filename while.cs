int contador = 1;

while (contador <= 4)
{
    Console.WriteLine(contador);
    contador++;
}

for (int contador = 1; contador <= 10; contador++)
{
    Console.WriteLine(contador);
}

string[] Compras = {
    "Arroz",
    "Feijão",
    "Macarrão",
    "Carne",
    "Frango"
};

foreach (string item in Compras)
{
    Console.WriteLine(item);
}

string[] nomes = {
    "João",
    "Maria",
    "José",
    "Ana",
    "Pedro"
};

foreach (string nome in nomes)
{
    Console.WriteLine($"Olá, {nome}");
}

int[] numeros = { 1, 2, 4, 5, 6, 7, 8, 9, 10 };
foreach (int numero in numeros)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine($"O número {numero} é par");
    }
    else
    {
        Console.WriteLine($"O número {numero} é ímpar");
    }
}

int[] numeros = {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20};
foreach (int numero in numeros)
{
    if (numero % 3 ==0)
    {
        Console.WriteLine($"O número {numero} é divisível por 3");
    }
    else
    {
        Console.WriteLine($"O número {numero} não é divisível por 3");
    }
}

double[] notas = { 7.5, 8.0, 6.5, 9.0, 5.5 };
int aprovados = 0;
int reprovados = 0;
double soma = 0;
double maiorNota = notas[0];
double menorNota = notas[0];
foreach (double nota in notas)
{
    soma += nota;
    if (nota >= 7)
    {
        aprovados++;
    }
    else
    {
        reprovados++;
    }
    if (nota > maiorNota)
    {
        maiorNota = nota;
    }
    if (nota < menorNota)
    {
        menorNota = nota;
    }
}
double media = soma / notas.Length;
Console.WriteLine($"A média das notas é: {media}");
Console.WriteLine($"A maior nota é: {maiorNota}");
Console.WriteLine($"A menor nota é: {menorNota}");
Console.WriteLine($"Quantidade de aprovados: {aprovados}");
Console.WriteLine($"Quantidade de reprovados: {reprovados}");
