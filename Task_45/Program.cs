// Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного копирования.

int[] array = new int[10] { 7, -28, 587, 43, -486, 93, 107, -72, 7, 2 };
int[] newArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    newArray[i] = array[i];
}
Console.WriteLine('[' + string.Join(", ", array) + ']');
Console.WriteLine('[' + string.Join(", ", newArray) + ']');
