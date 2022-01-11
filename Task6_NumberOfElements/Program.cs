// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(-100, 100);
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i],5}");
    Console.WriteLine();
}

int[] Array = FillArray(123);
PrintArray(Array);
int count = 0;
for (int i = 0; i < Array.Length; i++)
    if (Array[i] >= 10 && Array[i] <= 99)
        count++;
Console.WriteLine($"В массиве {count} чисел от 10 до 99");
