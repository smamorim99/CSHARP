using System.Runtime.InteropServices.Marshalling;

string permissao = "Aux";
int lvl = 5;

if (permissao.Contains("Adm") && lvl > 55)
    Console.WriteLine("Welcome, Super Admin user.");

else if (permissao.Contains("Adm") && lvl >=55)
    Console.WriteLine("Welcome, Admin user.");

else if (permissao.Contains("Gerente") && lvl >= 20)
    Console.WriteLine("Contact an Admin for access.");

else if (permissao.Contains("Gerente") && lvl < 20)
    Console.WriteLine("You do not have sufficient privileges.");
else 
    Console.WriteLine("You do not have sufficient privileges.");