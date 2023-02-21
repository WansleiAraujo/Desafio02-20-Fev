//Escreva um programa que informa o troco a ser recebido pelo cliente, por exemplo:

//-Valor final da compra: R$ 328,00
//- Pagamento: R$ 400,00
//- Troco:
//  -1 nota de 2 reais
//  - 2 notas de 10 reais
//  - 2 notas de 50 reais

Console.WriteLine("Calcular o troco:");
Console.WriteLine("Informe o valor da compra: ");
double compra = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor pago pelo cliente: ");
double pagamento = double.Parse(Console.ReadLine());

double troco = pagamento - compra;

int notas200 = 0;
int notas100 = 0;
int notas50 = 0;
int notas20 = 0;
int notas10 = 0;
int notas5 = 0;
int notas2 = 0;
int moedas1 = 0;
int moedas50 = 0;
int moedas25 = 0;
int moedas10 = 0;
int moedas5 = 0;

while (troco >= 200)
{
    notas200++;
    troco -= 200;
}
while (troco >= 100)
{
    notas100++;
    troco -= 100;
}
while (troco >= 50)
{
    notas50++;
    troco -= 50;
}
while (troco >= 20)
{
    notas20++;
    troco -= 20;
}
while (troco >= 10)
{
    notas10++;
    troco -= 10;
}
while (troco >= 5)
{
    notas5++;
    troco -= 5;
}

while (troco >= 2)
{
    notas2++;
    troco -= 2;
}

while (troco >= 1.00)
{
    moedas1++;
    troco -= 1.00;
}
while (troco >= 0.50)
{
    moedas50++;
    troco -= 0.50;
}
while (troco >= 0.25)
{
    moedas25++;
    troco -= 0.25;
}
while (troco >= 0.10)
{
    moedas10++;
    troco -= 0.10;
}
while (troco >= 0.05)
{
    moedas5++;
    troco -= 0.05;
}

Console.WriteLine("Notas a ser entregue ao cliente: ");
Console.WriteLine("NOTAS:");
if (notas200 > 0)
    Console.WriteLine("Notas de R$200: " + notas200);
if (notas100 > 0)
    Console.WriteLine("Notas de R$100: " + notas100);
if (notas50 > 0)
    Console.WriteLine("Notas de  R$50: " + notas50);
if (notas20 > 0)
    Console.WriteLine("Notas de  R$20: " + notas20);
if (notas10 > 0)
    Console.WriteLine("Notas de  R$10: " + notas10);
if (notas5 > 0)
    Console.WriteLine("Notas de   R$5: " + notas5);
if (notas2 > 0)
    Console.WriteLine("Notas de   R$2: " + notas2);
Console.WriteLine("MOEDAS:");
if (moedas1 > 0)
    Console.WriteLine("Moedas de  R$1: " + moedas1);
if (moedas50 > 0)
    Console.WriteLine("Moedas de R$0,50: " + moedas50);
if (moedas25 > 0)
    Console.WriteLine("Moedas de R$0,25: " + moedas25);
if (moedas10 > 0)
    Console.WriteLine("Moedas de R$0,10: " + moedas10);
if (moedas5 > 0)
    Console.WriteLine("Moedas de R$0,05: " + moedas5);