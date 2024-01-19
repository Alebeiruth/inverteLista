
//ATIVIDADE 01
string pangram = "The quick brown fox jumps over the lazy dog";

string[] menssagem = pangram.Split(" ");

string[] newMessagem = new string[menssagem.Length];

for(int i = 0; i < menssagem.Length; i++)
{
    char[] letras = menssagem[i].ToCharArray();
    Array.Reverse(letras);
    newMessagem[i] = new string(letras);
}
string resultado = String.Join(" ", newMessagem);
Console.WriteLine(resultado);


//ATIVIDADE 02
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] menssagem = orderStream.Split(",");
Array.Sort(menssagem);

foreach(var menssagens in menssagem)
{
    if(menssagem.Length == 4)
    {
        Console.WriteLine(menssagem);
    }
    else
    {
        Console.WriteLine(menssagem + "\t- Erro");
    }
}
