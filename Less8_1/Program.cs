//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] array = new int[,] { { 5, 20, 19, 12 }, { 1, 6, 3, 7 }, { 13, 2, 9, 4 } };
for (int i = 0; i < array.GetLength(0); i++)
{

    for (int j = 0; j < (array.GetLength(1) - 1); j++)
    {
        bool swap = false;
        int tmp = 0;
        for (int g = 0; g < (array.GetLength(1) - 1 - j); g++)
        {

            if (array[i, g] < array[i, g + 1])
            {

                tmp = array[i, g];
                array[i, g] = array[i, g + 1];
                array[i, g + 1] = tmp;
                swap = true;
            }

        }
        if (!swap)
        {
            break;
        }
    }

}

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
