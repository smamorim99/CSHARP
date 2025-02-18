//METODO SORT() E REVERSE()


/*string[] pallets = [ "B14", "A11", "B12", "A13"];

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

//METODO CLEAR() E RESIZE()


Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2...\n count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
    
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6... \nCount: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3... \ncount: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"--{pallet}");
}
*/
//METODO SLIP() E JOIN()

string value = "abc123";
char[] valueArray = value.ToCharArray();
//Console.WriteLine(valueArray);

Array.Reverse(valueArray);
//string result = new string(valueArray);
//Console.WriteLine(result);
string result = string.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (var item in items)
{
    Console.WriteLine(item);
}

