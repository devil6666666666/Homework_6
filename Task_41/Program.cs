// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите общее количество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] a = new int[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1}-е целое число: ");
    a[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine('[' + string.Join("; ", a) + ']');
int quantity = 0;
for (int i = 0; i < size; i++)
{
    if (a[i] > 0)
    {
        quantity++;
    }
}
Console.WriteLine($"Количество введенных положительных чисел: {quantity}");