int codigo;
int quantidade;
double conta = 0;
string[] comanda = new string[100];
int coontador = 0;

while(true)
{
    Console.WriteLine("Digite o codigo do produto que deseja adicionar ao pedido (ou 0 para finalizar): ");
    codigo = int.Parse(Console.ReadLine());

    if (codigo == 0)
        break;
        
    Console.Write("Digite a quantidade: ");
    quantidade = int.Parse(Console.ReadLine());
}
