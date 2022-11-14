// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
int[] array = new int[6];
FillArray(array);
PrintArray(array);
int sum = FindSumNumbers(array);
Console.WriteLine();
Console.Write("Сумма нечётных позиций : "+ sum);

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int FindSumNumbers(int[] array)
{
    int sum = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if (i % 2 > 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}
