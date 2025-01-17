
Console.WriteLine("Entre com a sua função");
bool funcao = false;

do{
    string entrada = Console.ReadLine().Trim().ToLower();
        
            if (entrada == "administrador" || entrada == "gerente" || entrada == "usuario")
                funcao = true; 
            else
                Console.WriteLine($" {entrada} não é uma funçaõ valida, entre com uma função valida!");   

}while (!funcao);
    Console.WriteLine("Acesso aceito! Bem vindo!");