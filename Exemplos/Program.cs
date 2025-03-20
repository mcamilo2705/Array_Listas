//Vetores
//Pegar 5 idades

//vetor/array



int[] idades = new int[5];
//int [] idades --> momento que cria o vetor e da o nome de idades
//new int [5] --> inicializar o vetor com 5 posicao

string [] nomes = new string[10];

//Posicao --> definindo valor na posicao
// 0 1 2 3 4 5 6 7 8 9
nomes[0] = "Marcos";
nomes[1] = Console.ReadLine();

Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[1]);


//FOR - Percorrer Listas/Vetores;
for (int j = 0; j < 10; j++)
{
    Console.WriteLine(j);
    Console.Write("Insira um nome: ");
    nomes[j] = Console.ReadLine();
}
//Listar os nomes armazenados no vetor
for (int j = 0; j < 10; j++)
{
    Console.Write(nomes[j]);
}

//FOREACH --> listar todos os nomes
foreach (var item in nomes)
{
    Console.Write(item);
}


//Criar um vetor de idades, use um for para preencher as idades e use o for para listar as idades. Usar 4 posicoes

string[] nomes1 = new string[4];
int[] idade1 = new int[4];

for (int i = 0; i >= 4; i++)
{
    Console.Write($"Digitar o nome {i+1}: ");
    nomes1[i] = Console.ReadLine();
    Console.Write($"Digite a idade {i+1}: ");
    idade1[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < nomes1.Length; i++)
{
    Console.WriteLine($"O nome {i+1} e {nomes1[i]} e a idade {1} e {idade1[i+1]}");
}

