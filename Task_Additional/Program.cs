// Напишите программу, которая принимает на вход
// число N и выдаёт произведение чисел от 1 до N - через рекурсию.

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int prod = 1;
void PrintNumbers(int number)
{
    if (number == 0)
    {
        return;
    }
    PrintNumbers(number - 1);
    prod = prod * number;
}
PrintNumbers(n);
Console.WriteLine($"Произведение чисел от 1 до N = {prod}");