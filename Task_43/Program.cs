//  Напишите программу, которая найдёт точку
//  пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите число b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
int count = 0;
double x = -1000;
double coordX = 0;
for (int i = 0; i < 2000000; i++)
{
    x = x + 0.001;
    if (k1 * x + b1 == k2 * x + b2)
    {
        count++;
        coordX = x;
    }
}
if (count == 0)
{
    Console.WriteLine("Прямые параллельны");
}
else if (count > 1)
{
    Console.WriteLine("Прямые совпадают");
}
else
{
    Console.WriteLine($"Прямые пересекаются в точке с координатами [{coordX};{k1 * coordX + b1}]");
}
// Не понимаю, почему программа не работает.
// Она находит точку пересечения, только если везде
// задавать целые числа, и координаты точки пересечения -
// тоже целые числа.