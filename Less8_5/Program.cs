//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 

int[,] arr = new int[4, 4];
int row = 0;
int col = 0;
int maxRow = arr.GetUpperBound(0);
int maxCol = arr.GetUpperBound(1);
int num = 1;
while (row <= maxRow && col <= maxCol)
{

    for (int i = col; i <= maxCol; i++)
    {
        arr[row, i] = num;
        num++;
    }
    row++;

    for (int i = row; i <= maxRow; i++)
    {
        arr[i, maxCol] = num;
        num++;
    }
    maxCol--;

    for (int i = maxCol; i >= col; i--)
    {
        arr[maxRow, i] = num;
        num++;
    }
    maxRow--;

    for (int i = maxRow; i >= row; i--)
    {
        arr[i, col] = num;
        num++;
    }
    col++;
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write("{0} ", arr[i, j]);
    }
    Console.WriteLine();
}
