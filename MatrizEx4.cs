Console.Write("Digite o valor de M (número de linhas): ");
int M = int.Parse(Console.ReadLine());

Console.Write("Digite o valor de N (número de colunas): ");
int N = int.Parse(Console.ReadLine());


double[,] matriz = new double[M, N];


for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write($"Digite o elemento da posição [{i}, {j}]: ");
        matriz[i, j] = double.Parse(Console.ReadLine());
    }
}
for (int i = 0; i < N; i++) 
{
    for (int j = 0; j < N; j++)
    {
        if (matriz[i, j] < 0)
        {
            Console.WriteLine($"Posição[{i},{j}]: {matriz[i, j]} ");
        }
    }
}
