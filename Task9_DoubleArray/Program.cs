// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

void EnterArray(double[] array)
{
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = rand.NextDouble() * 100;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i],8:N3}");
}

double MaxElement(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
    return max;
}

double MinElement(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
        if (array[i] < min)
            min = array[i];
    return min;
}

Console.Write("Введите размер массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
double[] array = new double[length];
EnterArray(array);
PrintArray(array);
Console.WriteLine();

double diff = MaxElement(array) - MinElement(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами = {diff,6:N3}");
