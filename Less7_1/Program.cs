//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int m = 3;
int n = 4;
Random random = new Random();
double[,] arrayNumbers = new double[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        arrayNumbers[i, j] = random.NextDouble() * 10;
    }
}
