// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();
int[] array = new int[6];
FillArray(array);
Console.Write("Array { ");
PrintArray(array);
Console.Write("}");
int number = FindEvenNumber(array);
Console.WriteLine();
Console.Write("Чётных чисел : "+ number);

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(100, 999);
    }
}

void PrintArray(int[] array)
{
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int FindEvenNumber(int[] array)
{
    int count = 0;
    for (var i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
