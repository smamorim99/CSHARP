string[] values = {"12,3", "45", "ABC", "11", "DEF"};
string messege = "";
decimal total = 0;

foreach (var value in values){
    decimal numeros;
    if (decimal.TryParse(value, out numeros)){
       total+= numeros;
    } else {
       messege += value;   
    } 
}
Console.WriteLine($"total: {total}");
Console.WriteLine($"messege: {messege}");