// Не используя рекурсию, выведите первые N чисел Фибоначчи.

Console.Write("Введите количество отображаемых чисел Фибоначчи: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
array[0]=0;
array[1]=1;
for (int count = 2; count < N; count++)
{
    array[count] = array[count-1]+array[count-2];
}
Console.WriteLine(string.Join(" ", array));
