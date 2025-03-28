// Write = Escreve ne mesma linha
// EX: Erick Borges 
// Writeline = Escreve na linha de baixo
// EX: Erick
// Borges

// Int = inteiro - usar quando for numeros
// Doubles = numero com casa decimal

// ReadLine = Retorna texto
// Int.Parse = Converte em numero

//,CultureInfo.InvariantCulture = serve para que o numero decimal fique com "."

using System.Globalization;


Console.Write("Informe seu nome completo: "); // Cria a variavel nome e recebe seu valor
string? nomeCompleto = Console.ReadLine(); // "?" no string obriga a pessoa digitar algo

Console.WriteLine(); // Linha em branco (tipo enter no word)

Console.Write("Quantos quartos tem na sua casa? ");
string linha = Console.ReadLine();

int quartos = 0;                    // Função SE para caso alguém não preencha
if(linha != null && linha != "")
{
    quartos = int.Parse(linha);

}
Console.WriteLine();
Console.Write("Informe o preco da sua internet: ");
double precoInternet = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
Console.WriteLine();
Console.Write("Informe seu ultimo nome, idade e altura");
string linhas = Console.ReadLine();
// Vetor de texto - divisão quando encontrar um espaço
string[] vetor = linhas.Split(' ');
string sobrenome = vetor[0];
int idade = int.Parse(vetor[1]);
double altura = double.Parse(vetor[2]);
Console.WriteLine(nomeCompleto);
Console.WriteLine(idade);
Console.WriteLine(quartos);
Console.WriteLine(precoInternet.ToString ("F2"));
Console.WriteLine(sobrenome);
Console.WriteLine(idade);
Console.WriteLine(altura.ToString("F2"));