using System.Runtime.Serialization.Formatters;
using System.Security.Cryptography.X509Certificates;

int atribuicoes = 5;

string[] NomeDosAlunos = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
int[] notaDosAlunos = new int[10];

string pontuacaoEmLetra = "";

int[] pontuacaoSophia = new int[] { 90, 86, 87, 98, 100, 94, 90};
int[] pontuacaoAndrew = new int[] { 92, 89, 81, 96, 90, 89 };
int[] pontuacaoEmma = new int[] { 90, 85, 87, 98, 68, 89, 89, 89};
int[] pontuacaoLogan = new int[] { 90, 95, 87, 88, 96, 96 };
int[] pontuacaoBecky = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] pontuacaoChris = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] pontuacaoEric = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] pontuacaoGregor = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

Console.WriteLine("Student\t\tGrade\n");

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
    else if (nomeAtual == "Becky")
        notaDosAlunos = pontuacaoBecky;
    else if (nomeAtual == "Chris")
        notaDosAlunos = pontuacaoChris;
    else if (nomeAtual == "Eric")
        notaDosAlunos = pontuacaoEric;
    else if (nomeAtual == "Gregor")
        notaDosAlunos = pontuacaoGregor;
    else
        continue;
    
    int somaDasNotas = 0;
    decimal notaAtualDosAlunos = 0;

    int notaExame = 0;

    foreach (int pontos in notaDosAlunos)
    {
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

    Console.WriteLine($"{nomeAtual}:\t\t" + notaAtualDosAlunos + "\t" + pontuacaoEmLetra);

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

