﻿double[,] mat = new double[10, 10];
int m, n;

Console.Write("Quantas linhas tem a matriz? ");
m = int.Parse(Console.ReadLine());

Console.Write("Quantas colunas tem a matriz? ");
n = int.Parse(Console.ReadLine());

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write($"Elemento [{i + 1},{j + 1}]: ");
        mat[i, j] = double.Parse(Console.ReadLine());
    }
}
int negativos = 0;
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] < 0)
        {
            negativos++;
        }
    }
}
Console.WriteLine($"\nValores negativos: {negativos}");