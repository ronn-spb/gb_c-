//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] array = new int[3, 3, 3];
Random random = new Random();
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
    {
        for (int z = 0; z < 3; z++)
        {
            array[x, y, z] = random.Next(10, 99);
        }
    }
}
for (int x = 0; x < 3; x++)
{
    for (int y = 0; y < 3; y++)
    {
        for (int z = 0; z < 3; z++)
        {
            Console.WriteLine("array[{0}, {1}, {2}] = {3}", x, y, z, array[x, y, z]);
        }
    }
}
