//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


int[,] matrix1 = { {3, 4},
                    {2, 7}};

int[,] matrix2 = { {2, 8},
                   {1, 6}};


int[,] result = new int[2, 2];


for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            result[i, j] += matrix1[i, k] * matrix2[k, j];
        }
    }
}


for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        Console.Write(result[i, j] + "\t");
    }
    Console.WriteLine();
}

