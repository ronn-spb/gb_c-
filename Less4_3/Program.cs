//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] myArray = new int[8] { 1, 7, 6, 4, 10, 6, 4, 8 };
for (int i = 0; i <= myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}