// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
// C хитрым вводом сразу всего массива через пробел 

void PrintArray(int[] array)
{
    Console.WriteLine("Ваш массив:");
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i],4}");
    Console.WriteLine();
}
Console.WriteLine("Введите массив через пробел:");
int[] array = (Console.ReadLine() ?? "0").Split(' ').Select(int.Parse).ToArray(); // ЭТО ОН
PrintArray (array);
int sum = 0;
for (int i = 0; i < array.Length; i = i + 2)
    sum = sum + array[i];
Console.WriteLine ($"Сумма чисел на нечетных позициях {sum}");


