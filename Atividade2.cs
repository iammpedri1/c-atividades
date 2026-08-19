/1)
int senha = 1234;
Console.WriteLine("Digite a senha: ");
senha = int.Parse(Console.ReadLine());
if (senha == 1234)
{
    Console.WriteLine("Senha correta. Acesso permitido");
}
else
{
    Console.WriteLine("Senha incorreta. Acesso negado");
}

//2)
int limite = 80;
double multa = 5.00;
double valorMulta = 0.0;
Console.WriteLine("Digite a velocidade do veículo: ");
limite = int.Parse(Console.ReadLine());

if (limite > 80)
{
    Console.WriteLine("Você foi multado!");
    valorMulta = (limite - 80) * multa;
    Console.WriteLine($"Valor da multa: {valorMulta:C}");
}
else
{
    Console.WriteLine("Velocidade dentro do limite. Boa viagem!!");
}

//3)
int idade = 0;
Console.WriteLine("Digite sua idade: ");
idade = int.Parse(Console.ReadLine());

if (idade <= 13)
{
    Console.WriteLine("Você é uma criança.");
}
else if (idade <= 17)
{
    Console.WriteLine("Você é um adolescente");
}
else if (idade <= 59)
{
    Console.WriteLine("Você é um adulto");
}
else
{
    Console.WriteLine("Você é um idoso");
}

//4)
Console.WriteLine("Escolha uma opção: ");
Console.WriteLine("1 - Cachorro Quente (R$ 10,00)");
Console.WriteLine("2 - Hambúrguer (R$ 15,00)");
Console.WriteLine("3 - Pizza (R$ 30,00)");

int opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Cachorro Quente (R$ 10,00)");
        break;
    case 2:
        Console.WriteLine("Hambúrguer (R$ 15,00)");
        break;
    case 3:
        Console.WriteLine("Pizza (R$ 30,00)");
        break;
    default:
        Console.WriteLine("Opção inválida. Tente novamente");
        break;
}


//5)
Console.Write("Digite o primeiro número: ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Digite o segundo número: ");
double num2 = double.Parse(Console.ReadLine());
Console.WriteLine("\n1- Soma " +
    "2- Subtração " +
    "3- Multiplicação " +
    "4- Divisão");
Console.Write("Escolha a opção: ");
int opcao = int.Parse(Console.ReadLine());
switch (opcao)
{
    case 1:
        Console.WriteLine("Resultado: " + (num1 + num2));
        break;
    case 2:
        Console.WriteLine("Resultado: " + (num1 - num2));
        break;
    case 3:
        Console.WriteLine("Resultado: " + (num1 * num2));
        break;
    case 4:
        if (num2 != 0)
            Console.WriteLine("Resultado: " + (num1 / num2));
        else
            Console.WriteLine("Erro: Divisão por zero!");
        break;
    default:
        Console.WriteLine("Opção inválida!");
        break;
}


//6)
double valor = 20.00;
Console.WriteLine("Digite qual dia da semana deseja ir: ");
Console.WriteLine("1 - Segunda");
Console.WriteLine("2 - Terça");
Console.WriteLine("3 - Quarta");
Console.WriteLine("4 - Quinta");
Console.WriteLine("5 - Sexta");
Console.WriteLine("6 - Sábado");
Console.WriteLine("7 - Domingo");
int dia = int.Parse(Console.ReadLine());

switch (dia)
{
    case 1:
        Console.WriteLine("Segunda");
        break;
    case 2:
        Console.WriteLine("Terça");
        break;
    case 3:
        Console.WriteLine("Quarta");
        Console.WriteLine("Promoção do Dia!");
        valor = 10.00;
        break;
    case 4:
        Console.WriteLine("Quinta");
        break;
    case 5:
        Console.WriteLine("Sexta");
        break;
    case 6:
        Console.WriteLine("Sábado");
        break;
    case 7:
        Console.WriteLine("Domingo");
        break;
    default:
        Console.WriteLine("Opção Inválida. Tente Novamente");
        break;
}

Console.WriteLine("Você é estudante(s/n): ");
string estudante = Console.ReadLine().ToLower();
if (estudante == "s")
{
    valor -= 5.00;

}
else if (estudante == "n")
{
    Console.WriteLine("Sem desconto!");
}

Console.WriteLine($"Valor total a pagar {valor}");

