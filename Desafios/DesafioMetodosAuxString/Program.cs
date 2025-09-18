/*const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

quantity = input.Remove(0, 35).Remove(4, 13);
output = input.Remove(0, 5).Replace("trade","reg").Remove(39,6);


Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");*/

using System.Data;

const string input = "<section><h1>Produtos &copy;</h1><p>Quantidade: 120</p></section>";

string quantity = "";
string output = "";

//mostra a quantidade que está entre as tags de paragrafo. 
const string openParagraph = "<p>";
const string closingParagraph = "</p>";

int openingPosition = input.IndexOf(openParagraph);
int closingPosition = input.IndexOf(closingParagraph);

openingPosition += openParagraph.Length;
int length = closingPosition - openingPosition;

quantity = input.Substring(openingPosition, length);

//substitui o simbolo de copia, pelo simbolo de registrado. 
const string copySymbol = "&copy;";
const string regSymbol = "&reg";

output = input.Replace(copySymbol, regSymbol);

//remove as tags de abertura e fechamento de sessãobb
const string openSection = "<section>";

int startOpenSection = output.IndexOf(openSection);
output = output.Remove(startOpenSection, openSection.Length);

const string closeSection = "</section>";

int endOpenSection = output.IndexOf(closeSection);
output = output.Remove(endOpenSection, closeSection.Length);


Console.WriteLine(quantity);
Console.WriteLine($"Output: {output}");



