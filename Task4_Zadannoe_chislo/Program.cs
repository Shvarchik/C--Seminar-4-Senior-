// 35. Определить, присутствует ли в заданном массиве, некоторое число
//     длина массива и сам массив - вводятся вручную

int[] EnterArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = int.Parse(Console.ReadLine() ?? "0");
    }
    return array;
}

bool ContainNumber(int[] array, int N)
{
    for (int i = 0; i < array.Length; i++)

        if (array[i] == N)
            return true;

    return false;
}

Console.WriteLine("Введите размер массива:");
int length = int.Parse(Console.ReadLine() ?? "0");
int[] array = EnterArray(length);

Console.Write("Введите искомое число: ");
int N = int.Parse(Console.ReadLine() ?? "0");
if (ContainNumber(array, N) == true)
    Console.WriteLine($"Массив содержит {N}");
else
    Console.WriteLine($"Массив не содержит {N}");


