int codigo;
int quantidade;
double conta = 0;

string[] comanda = new string[100];
int coontador = 0;

while (true)
{
    Console.WriteLine("\nMenu de Produtos:");
    Console.WriteLine("1 - Hambúrguer - R$ 15,00");
    Console.WriteLine("2 - Refri - R$ 5,00");
    Console.WriteLine("3 - Pizza - R$ 20,00");
    Console.WriteLine("0 - Finalizar pedido");
    Console.Write("Digite o codigo do produto que deseja adicionar ao pedido: ");

    codigo = int.Parse(Console.ReadLine());

    if (codigo == 0)
        break;

    switch (codigo)
    {
        case 1:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());
            conta += quantidade * 15.0;
            comanda[coontador] = $"Hambúrguer - {quantidade} unidades";
            coontador++;
            break;
        case 2:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            conta += quantidade * 5.0;
            comanda[coontador] = $"Refri - {quantidade} unidades";
            coontador++;
            break;
        case 3:
            Console.Write("Digite a quantidade: ");
            quantidade = int.Parse(Console.ReadLine());

            conta += quantidade * 20.0;
            comanda[coontador] = $"Pizza - {quantidade} unidades";
            coontador++;
            break;

        default:
            Console.WriteLine("Código inválido. Tente novamente.");
            break;
    }
}

Console.WriteLine("\nPedido finalizado. Comanda:");

for (int i = 0; i < coontador; i++)
{
    Console.WriteLine(comanda[i]);
}

Console.WriteLine($"Total a pagar: R$ {conta:F2}");
