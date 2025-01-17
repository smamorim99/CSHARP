/*for (int i = 0; i < 10; i++){
    Console.WriteLine(i);}

for (int i = 0; i < 10; i++){
    Console.WriteLine(i);
    if (i== 7) 
    break;
}*/

/*string[] nomes = {"Alex", "Eddie", "David", "Michael"};
for (int i = nomes.Length - 1; i >= 0; i--){
    Console.WriteLine(nomes[i]);
}*/

/*string[] nomes = {"Alex", "Eddie", "David", "Michael"};
foreach (var nome in nomes){
    if (nome == "David")
        nome = "Sammy";
}*/

string[] nomes = {"Alex", "Eddie", "David", "Michael"};
for (int i = 0; i < nomes.Length; i++)
    if (nomes[i] == "David")
        nomes[i] = "Summy";

foreach (var nome in nomes)
    Console.WriteLine(nome);
    

