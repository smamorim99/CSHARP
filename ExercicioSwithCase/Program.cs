int lvlFuncionario = 100;
string nomeFuncionario = "Jhon Smith";

string titulo = "";

switch (lvlFuncionario){
    case 100: 
    case 200: 
    titulo = "Assistente Senior";
    break;
    case 300:
    titulo = "Gerente";
    break;
    case 400:
    titulo = "Gerente Senior";
    break;
    default:
    titulo = "Associado";
    break;
}
Console.WriteLine($"{nomeFuncionario}, {titulo}");