

/*int numA = Convert.ToInt32(Console.ReadLine());
int numB = Convert.ToInt32(Console.ReadLine());
int numC = Convert.ToInt32(Console.ReadLine());
int soma = numA + numB;

if(soma > numC)
{
    Console.WriteLine($"A soma de A = {numA} e B= {numB} é maior que C");
}
else 
{ 
    Console.WriteLine("A soma de A e B não  é maior que C");
}*/

/*/Random random = new Random(-10, 10);
int numero = random.Next();*/
/*int numero = Convert.ToInt32(Console.ReadLine());

if (numero % 2 == 0 && numero > 0)
{
    Console.WriteLine($"O numero {numero} é par e positivo");
}
    else if(numero % 2 == 1 && numero < 0)
    {
    Console.WriteLine("O numero é impar e negativo");
    }
    else if (numero % 2 == 0 || numero < 0)
    {
    Console.WriteLine("O numero é par e negativo");
    }
    else if (numero % 2 == 1 || numero > 0)
    {
    Console.WriteLine("O numero é impar e positivo");
    }*/

/*int A = Convert.ToInt32(Console.ReadLine());
int B = Convert.ToInt32(Console.ReadLine());
int C;

if(A == B)
{
    C = A+B;
    Console.WriteLine($"A e B são iguais, o resultado de sua soma é {C}");
} 
else if (A != B)
{
    C = A * B;
    Console.Write($"A e B são diferentes e o resultado de sua multiplicação é: {C}");
}*/

/*int numero = int.Parse(Console.ReadLine());

int sucessor = numero +1;
int antecessor = numero -1;

Console.WriteLine($"numero = {numero}");
Console.WriteLine($"antecessor = {antecessor}");
Console.WriteLine($"sucessor = {sucessor}");*/

/*double salarioMinimo = 1293.20;
double salarioUser = double.Parse(Console.ReadLine());
double qtdSalarios = salarioUser / salarioMinimo;
Console.WriteLine($"O usuario recebe  {Math.Round(qtdSalarios)} slarios minimos");
*/

using System.Data;

/*int valor = Convert.ToInt32(Console.ReadLine());
double porcentagem = valor * 0.05;
int reajuste = valor - (int)porcentagem;
Console.WriteLine($"O valor com reajuste é {reajuste}");*/

 void Multiplicação (Multiplicacao)
{
    int numA = Convert.ToInt32(Console.ReadLine());
    int multiplicacão;
    for(int i = 0; i <= 10; i++)
    {
        multiplicacão = numA * 1;
        Console.WriteLine(multiplicacão);

    }
}
    
