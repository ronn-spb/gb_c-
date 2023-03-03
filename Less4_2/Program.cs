//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int sum = 0;
while (number > 0)
{
    int digit = number % 10;
    sum += digit;
    number /= 10;
}
Console.WriteLine($"Сумма цифр равна {sum}");


