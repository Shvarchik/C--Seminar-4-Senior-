// 34. Написать программу замену элементов массива на противоположные
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i],4}  ");
}

Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 10);

PrintArray(array);
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
    array[i] = array[i] * -1;

PrintArray(array);
