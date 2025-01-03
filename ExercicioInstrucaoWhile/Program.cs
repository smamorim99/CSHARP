Random numeros = new();
int current = numeros.Next(1, 11);

/*do{
    current = numeros.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

/*while (current >= 3){
    Console.WriteLine(current);
    current = numeros.Next(1, 11);
}
Console.WriteLine($"ultino numero: {current}");*/

do{ 
    current = numeros.Next(1,11);
    
    if (current >= 8)
    continue;

    Console.WriteLine(current);
} while (current != 7);
