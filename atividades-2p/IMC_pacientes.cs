Console.WriteLine("Cadastro de pacientes");

while (true)
{
    Console.Write("Digite o nome do paciente (ou sair): ");
    string nomePaciente = Console.ReadLine();

    if (nomePaciente.ToLower() == "sair")
        break;

    Console.Write("Digite o peso do paciente (em kg): ");
    double pesoPaciente = double.Parse(Console.ReadLine().Replace(".", ","));

    Console.Write("Digite a altura do paciente (em metros): ");
    double alturaPaciente = double.Parse(Console.ReadLine().Replace(".", ","));

    double imc = pesoPaciente / (alturaPaciente * alturaPaciente);

    if (imc < 18.5)
        Console.WriteLine($"Paciente {nomePaciente} está abaixo do peso. IMC: {imc:F2}");
    else if (imc < 25)
        Console.WriteLine($"Paciente {nomePaciente} está com peso normal. IMC: {imc:F2}");
    else if (imc < 30)
        Console.WriteLine($"Paciente {nomePaciente} está com sobrepeso. IMC: {imc:F2}");
    else
        Console.WriteLine($"Paciente {nomePaciente} está com obesidade. IMC: {imc:F2}");
}
