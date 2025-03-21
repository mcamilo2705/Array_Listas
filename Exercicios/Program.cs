//Crie um vetor com 5 elementos, e liste todos os elementos do vetor utilizando um For

using System.Xml;

string[] elementos  = new string[5];

try
{
    for (int i = 0; i <= 4; i++)
    {
        Console.Write($"Digite o nome {i + 1}: ");
        elementos[i] = Console.ReadLine();
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Informar apenas numeros!");
}
Console.WriteLine("Resultado com FOR: ");
for (int i = 0; i < elementos.Length; i++)
{
    Console.WriteLine(elementos[i]);
}
Console.WriteLine("");
Console.WriteLine("Resultado com FOREACH: ");
foreach (var item in elementos)
{ 
    Console.WriteLine(item);
}

//Crie um programa que declare um array de 5 números inteiros e utilize um laço de repetição para somar todos os valores. No final, exiba a soma na tela.

int[] num = new int[5];
int somar =0;
int somar2 = 0;

try
{
    for (int i = 0; i <= 4; i++)
    {
        Console.Write($"Digite o numero {i + 1}: ");
        num[i] = int.Parse(Console.ReadLine());
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Informar apenas numeros!");
}
for (int i = 0; i < num.Length; i++)
{
    somar += num[i];
    
}
Console.WriteLine("Resultado com FOR:" + somar);

foreach (var item in num)
{
    somar2 += item;
}
Console.WriteLine("Resultado com FOREACH:" + somar2);


//Crie um programa que declare um array de 5 números inteiros e utilize um laço de repetição para encontrar o maior número do array. No final, exiba o maior valor encontrado.

int[] num1 = new int[5];
int maior = 0;
try
{
    for (int i = 0; i <= 4; i++)
    {
        Console.Write($"Digite o numero {i + 1}: ");
        num1[i] = int.Parse(Console.ReadLine());
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Informar apenas numeros!");
}
for (int i = 0; i < num1.Length; i++)
{
    if (num1[i] > maior)
    {
        maior = num1[i];
    }
}
Console.WriteLine("Resultado com FOR: " + maior);
Console.WriteLine("Resultado com MAX: " + num1.Max());

//Peça ao usuário 10 números, armazene em um array e exiba a quantidade de números pares inseridos.

int[] num2 = new int[10];
int par = 0;
int impar = 0;

try
{
    for (int i = 0; i <= 9; i++)
    {
        Console.Write($"Digite o numero {i + 1}: ");
        num2[i] = int.Parse(Console.ReadLine());
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Informar apenas numeros!");
}
for (int i = 0; i < num2.Length; i++)
{
    if(num2[i] % 2 == 0)
    {
        par++;
    }
    else
    {
        impar++;
    }
}
Console.WriteLine($"Na lista contem {par} numeros pare e {impar} numeros impar");

//Crie um programa que recebe 8 números em um array e exibe os valores na ordem inversa à que foram inseridos.

int[] num3 = new int[8];

try
{
    for (int i = 0; i <= 7; i++)
    {
        Console.Write($"Digite 8 numeros, {i + 1}: ");
        num3[i] = int.Parse(Console.ReadLine());
    }
}
catch (FormatException)
{
    Console.WriteLine("Error: Informar apenas numeros!");
}
for (int i = (num3.Length)-1; i <= num3.Length; i--)
{
    Console.WriteLine($"Na lista contem {num3[i]}");
}

//Peça ao usuário 10 números e um número adicional. O programa deve contar e exibir quantas vezes esse número aparece no array.




