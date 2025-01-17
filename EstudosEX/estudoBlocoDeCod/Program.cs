/*bool flag = true;
int value = 0;

if (flag){
   Console.WriteLine($"Inside the code block: {value}");
} 

value = 10;
Console.WriteLine($"Outside the code block: {value}");*/

// Code sample 1
/*bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");*/

// Code sample 2
/*int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");*/

int variavel1 = 5;
if (variavel1 > 0){
   int variavel2 = 6;
   variavel1 = variavel1 + variavel2;
}
Console.WriteLine(variavel1);