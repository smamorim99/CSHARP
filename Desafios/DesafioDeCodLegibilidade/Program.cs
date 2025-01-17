/* O codigo inverte a menssagem, conta o numero de vezes que o caracter "O" aparece,
então imprime o resultado no terminal.*/


string message = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = message.ToCharArray();
Array.Reverse(charMessage);

int numeroDeRepetição = 0;
foreach (char letra in charMessage){ 
    if (letra == 'o'){ 
    numeroDeRepetição++; 
    } 
}
string newMessage = new String(charMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {numeroDeRepetição} times.");