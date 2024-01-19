
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

