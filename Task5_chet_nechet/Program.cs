// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

void ArrayOfRandom(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i],5}");
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива:");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = new int[length];
ArrayOfRandom(array);
PrintArray(array);

int NumberChet = 0;
int NumberNechet = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
        NumberChet++;
    else NumberNechet++;
}
Console.WriteLine($"В массиве четных чисел: {NumberChet}; нечетных: {NumberNechet}.");

