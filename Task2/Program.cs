// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива

int[] array = new int[12];
int sum = 0;

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 10);

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i],3}");
    Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        sum = sum + array[i];
}
Console.WriteLine($"Cумма {sum}");

