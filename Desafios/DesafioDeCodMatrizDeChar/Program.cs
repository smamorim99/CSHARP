String[] minhasStrings = new string [2] {"I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"};

int localizacaoDosPontos = 0;
string myString = "";

int contadorString = myString.Length;

for (int i = 0; i < contadorString; i++){
    myString = minhasStrings[i];
    localizacaoDosPontos = myString.IndexOf(".");
    
    string minhaFrase;

    while (localizacaoDosPontos != -1){
        minhaFrase = myString.Remove(localizacaoDosPontos);

        myString = myString.Substring(localizacaoDosPontos + 1);

        myString = myString.TrimStart();

        localizacaoDosPontos = myString.IndexOf(".");

        Console.WriteLine(minhaFrase);
    }
minhaFrase = myString.Trim();
Console.WriteLine(minhaFrase);
}

