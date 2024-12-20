Random random = new();
int diasAteOVencimento = random.Next(12);
//int diasAteOVencimento = 9;//
int porcentagemDeDesconto = 0;

if (diasAteOVencimento <= 11){
    //Console.WriteLine("Sua incrição vencerá logo. Renove agora");
    if (diasAteOVencimento <=5){
        porcentagemDeDesconto = porcentagemDeDesconto + 10;
        Console.WriteLine($"Sua inscrição vencerá em {diasAteOVencimento} dias \nRenove agora e ganhe {porcentagemDeDesconto}% de desconto");
        
    }
    else if (diasAteOVencimento == 1){
         porcentagemDeDesconto = porcentagemDeDesconto + 20;
        Console.WriteLine($"Sua inscrição vencerá em um dia!\nRenove agora e ganhe {porcentagemDeDesconto}% de desconto");
           
    }
    else if (diasAteOVencimento == 0){
        Console.WriteLine("Sua inscrição está vencida");
    }
    else {
        Console.WriteLine("Sua incrição vencerá logo. Renove agora");
    }
if (porcentagemDeDesconto > 0){
    Console.WriteLine("Renove e garanta desconto na assinatura");
}
}