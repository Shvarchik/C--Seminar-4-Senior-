// 39. Найти произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Пусть будет массив случайных чисел и случайной длины. 
// Пусть если элементов нечетное количество, средний умножается сам на себя.

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i],5}");
    Console.WriteLine();
}

int[] CreateArray()
{
    int length = new Random().Next(4, 21);
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(-10, 11);
    return array;
}

int[] Array = CreateArray();
Console.WriteLine($"Ваш массив:");
PrintArray(Array);

// определяем длину массива произведений
int MultLength = Array.Length / 2;
if ((Array.Length % 2) != 0)
    MultLength = MultLength + 1;

// заполняем массив произведений
int[] MultArray = new int[MultLength];
for (int i = 0; i < MultLength; i++)
    MultArray[i] = Array[i] * Array[Array.Length - i - 1];

Console.WriteLine("Произведения пар чисел:");
PrintArray(MultArray);
