//coversao de expansão 

/*int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");

//conversão de restrição com coerção cast

/*decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}"); */

//conversão de dados usando o métod ToString() int ---> string

/*int first = 5;
int second= 7;
string messege = first.ToString() + second.ToString();
Console.WriteLine(messege);*/

// conversao usando o método Parse() string ----> int
// a melhor maneira de evitar erros de runtime nesses casos é utilizar o método TryParse();

/*string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

//conversao usando a classe Convert
// a classe Convert é melhor utilizada quando convertemos numeros fracionarios para inteiro, pois os arrendoda de maneira esperada
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);

//comversao de decimal para int utilizando (int) ou a classe Convert.ToInt32()

int value = (int)1.5m; // casting truncates (arredonda para o valor anterior a vigula (1))
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up (converte seguindo as regras corretas para arredondamento)
Console.WriteLine(value2);

//metodo TryParse() para analisar um string, utilizando um parametro de saida (out) e uma operacao bool para indicar o sucesso ou falha da conversao
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}*/

//utilizndo a varivael result mais adiante no cod
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");

