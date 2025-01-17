// valida a entrada de usuario usando as instrução de interação do/while
bool entradaValida = false;

Console.WriteLine ("Dite um numero entre 5 e 10 para entrar");

do{ int? entradaDoUsuario = null;
    string? entrada = Console.ReadLine();

    if (int.TryParse(entrada, out int resultado))
        entradaDoUsuario = resultado;

    if (entradaDoUsuario > 5 && entradaDoUsuario <= 10)
        entradaValida = true;
    else 
        Console.WriteLine ("entra Invalida, tente novamente");
} while (!entradaValida);
    Console.WriteLine("entrada valida, Bem vindo!");
 