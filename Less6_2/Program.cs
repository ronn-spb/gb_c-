//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
double k1, k2, b1, b2;



Console.Write("Введите значение k1: ");
k1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b1: ");
b1 = double.Parse(Console.ReadLine());
Console.Write("Введите значение k2: ");
k2 = double.Parse(Console.ReadLine());
Console.Write("Введите значение b2: ");
b2 = double.Parse(Console.ReadLine());
if (k1 != k2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых: x={x}, y={y}");
    return;
}


Console.WriteLine("Прямые не пересекаются!!");