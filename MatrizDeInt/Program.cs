using System.ComponentModel;

int[] inventario = {200, 450, 700, 175, 250};
int soma = 0;
int bin = 0;
foreach (int itens in inventario){
soma += itens;
bin++;
Console.WriteLine($"Bin {bin} = {itens} items (mostrando o total: {soma})");

}
Console.WriteLine($"existem {soma} itens no inventário");
