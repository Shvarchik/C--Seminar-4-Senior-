Console.Write("Введите длину массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");
int[]  array = new int [length];

for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(0, 10);

for (int i = 0; i < array.Length; i++)
    Console.WriteLine(array[i]);
