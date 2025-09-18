/* 
string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

Console.WriteLine(openingPosition);
Console.WriteLine(closingPosition);

string message = "Find what is (inside the parentheses)";
int openingPosition = message.IndexOf('(');
int closingPosition = message.IndexOf(')');

openingPosition += 1;

int length = closingPosition - openingPosition;

Console.WriteLine(message.Substring(openingPosition, length));


using System.Runtime.CompilerServices;

string message = "What is the value <span>between the tags</span>?";

int openingPosition = message.IndexOf("<span>");
int closingPosition = message.IndexOf("</span>");

openingPosition += 6;

int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


using System.Data;

string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";
bbbb
int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


string message = "hello there!";

int first_h = message.IndexOf('h');
int last_h = message.LastIndexOf('h');

Console.WriteLine($"for the message: {message}, the first 'h' is at the position {first_h} and the last 'h' is at the position {last_h}");


string message = "(What if) I am (only interested) in the last (set of parentheses)?";

int openingPosition = message.LastIndexOf('(');

openingPosition += 1;

int closingPosition = message.LastIndexOf(')');
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));


using System.Data;

string message = "(What if) there are (more than) one (set of parentheses)?";

while (true)
{
    int openingPosition = message.IndexOf('(');
    if (openingPosition == -1) break;

    openingPosition += 1;
    int closingPosition = message.IndexOf(')');
    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));

    message = message.Substring(closingPosition + 1);
}


string message = "H[ello, world!";
char[] charsToFind = { 'a', 'e', 'i', '[', '!' };
b
int index = message.IndexOfAny(charsToFind);

Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");


string message = "Help (find) the {opening symbols}";
Console.WriteLine($"Serching THIS Message: {message}");
char[] openSymbols = { '[', '{', '(' }; 

int startPosition = 5;
int openingPosition = message.IndexOfAny(openSymbols);
Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");
openingPosition = message.IndexOfAny(openSymbols, startPosition);
Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");


string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closuing symbol]?";
char[] openSymbols = { '[', '{', '(' };

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}


string data = "12345John Smith          bb5000  3  ";
string updatedata = data.Remove(5, 20);
Console.WriteLine(updatedata);


string message = "This-- is--ex-amp-ple--da-ta";
message = message.Replace("--", " ");
message = message.Replace("-", "");
Console.WriteLine(message);
*/
