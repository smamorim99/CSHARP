
int atribuicoes = 5;

string[] NomeDosAlunos = new string[] { "Sophia", "Andrew", "Emma", "Logan"};
int[] notaDosAlunos = new int[10];

string pontuacaoEmLetra = "";

int[] pontuacaoSophia = new int[] { 90, 86, 87, 98, 100, 94, 90};
int[] pontuacaoAndrew = new int[] { 92, 89, 81, 96, 90, 89 };
int[] pontuacaoEmma = new int[] { 90, 85, 87, 98, 68, 89, 89, 89};
int[] pontuacaoLogan = new int[] { 90, 95, 87, 88, 96, 96 };


Console.WriteLine("Aluno\t\tNota prova\t\tNota Geral\t\tCréditos Extra\n");

foreach (string nome in NomeDosAlunos)
{
    string nomeAtual = nome;

    if (nomeAtual == "Sophia")
        notaDosAlunos = pontuacaoSophia;
    else if (nomeAtual == "Andrew")
        notaDosAlunos = pontuacaoAndrew;
    else if (nomeAtual == "Emma")
        notaDosAlunos = pontuacaoEmma;
    else if (nomeAtual == "Logan")
        notaDosAlunos = pontuacaoLogan;
    else
        continue;
    
    int somaDasNotas = 0;
    int notaExame = 0;

    int pontosExame = 0;
    int somaDePontosExame = 0;

    int creditoExtra = 0;
    int somaCreditorExtra = 0;

    decimal exames = 0;
    decimal pontosExtraTotais = 0;
    decimal notaAtualDosAlunos = 0;
    foreach (int pontos in notaDosAlunos)
             notaExame += 1;
        if (notaExame <= atribuicoes)
            somaDasNotas += pontos;
        else 
            somaDasNotas += pontos/10; 
    }
    notaAtualDosAlunos = (decimal)somaDasNotas / atribuicoes;

    if (notaAtualDosAlunos >= 97)
        pontuacaoEmLetra = "A+";
    else if (notaAtualDosAlunos >= 93)
        pontuacaoEmLetra = "A";
    else if (notaAtualDosAlunos >= 90)
        pontuacaoEmLetra = "A-";
    else if (notaAtualDosAlunos >= 87)
        pontuacaoEmLetra = "B+";
    else if (notaAtualDosAlunos >= 83)
        pontuacaoEmLetra = "B";
    else if (notaAtualDosAlunos >= 80)
        pontuacaoEmLetra = "B-";
    else if (notaAtualDosAlunos >= 77)
        pontuacaoEmLetra = "C+";
    else if (notaAtualDosAlunos >= 73)
        pontuacaoEmLetra = "C";
    else if (notaAtualDosAlunos>= 70)
        pontuacaoEmLetra = "C-";
    else if (notaAtualDosAlunos>= 67)
        pontuacaoEmLetra = "D+";
    else if (notaAtualDosAlunos >= 63)
        pontuacaoEmLetra = "D";
    else if (notaAtualDosAlunos >= 60)
        pontuacaoEmLetra = "D-";
    else
        pontuacaoEmLetra = "F";

    Console.WriteLine($"{nomeAtual}:\t\t" + exames + "\t\t\t" + notaAtualDosAlunos + "\t" + pontuacaoEmLetra + "\t\t" + creditoExtra + "(0 pts)");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
