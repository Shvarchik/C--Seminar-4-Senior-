
int[] array = new int[12];
int sum = 0;

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 10);

for (int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        sum = sum + array[i];
}
Console.WriteLine(sum);

