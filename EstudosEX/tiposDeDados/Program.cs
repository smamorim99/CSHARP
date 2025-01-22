//tipos de valor
/*Console.WriteLine("Signed integral types");

Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"shot: {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int: {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long: {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");


Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");*/

//valores de referencia

int [] data = new int[3];

string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);

int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");

/*Quando ref_B = ref_A é executado, ref_B aponta para o mesmo local de memória que ref_A. Portanto, quando ref_B[0] é alterado, ref_A[0] também é alterado porque ambos apontam para o mesmo local de memória. Essa é uma diferença fundamental entre os tipos de valor e os tipos de referência.*/