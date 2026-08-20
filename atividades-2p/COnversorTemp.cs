string[] cidades = new string[5];
double[] temperaturaCelsius = new double[5];
for (int i = 0; i < cidades.Length; i++)
{
    Console.Write($"Digite o nome da {i + 1}ª cidade: ");
    cidades[i] = Console.ReadLine();

    Console.Write($"Digite a temperatura em Celsius da {i + 1}ª cidade: ");
    temperaturaCelsius[i] = double.Parse(Console.ReadLine());
    double fanhrenheit = temperaturaCelsius[i] * 1.8 + 32;
    Console.WriteLine($"A temperatura em Fahrenheit da {i + 1}ª cidade é: {fanhrenheit:F2}");

    if (temperaturaCelsius[i] < 15)
    {
        Console.WriteLine("Clima: frio");

    }
    else if (temperaturaCelsius[i] <= 25)
    {
        Console.WriteLine("Clima: Agradavel");
    }
    else
    {
        Console.WriteLine("Clima: quente");
    }

}


