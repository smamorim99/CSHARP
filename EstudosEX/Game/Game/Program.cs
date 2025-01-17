Random dice = new();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);



int total = roll1 + roll2 + roll3;

Console.WriteLine($"rolagem dos dados {roll1} + {roll2} + {roll3} = {total}");
//ex de condição composta com operadores lógicos "pipe duplo" (OPERADOR OR)
if (roll1 == roll2 || roll2 == roll3 || roll1 == roll3){
//ex de condição composta com operadores lógicos "E comencial" (OPERADOR AND)
    if ((roll1 == roll2) && (roll2 == roll3)){
    Console.WriteLine("You rolled triples! +6 bonus to total");
    total += 6;

} 
    else {
     Console.WriteLine("You rolled doublest! +2 bonus to total");
   total+=2;
}
}

Console.WriteLine("sua pontuação gerou premios!!!");

if (total >= 16){
    Console.WriteLine("você ganhou um carro novo");
}
else if (total >=10){
    Console.WriteLine("você ganhou um laptop");
}
else if (total == 7){
    Console.WriteLine("você ganhou uma viagem");
}
else {
    Console.WriteLine("voce ganhou uma pelucia");
}




