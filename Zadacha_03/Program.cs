//  Задача 38: Задайте массив вещественных чисел. 
//  Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetArray(int size, int start, int end)
{
    int[] array = new int[size];
    var rng = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rng.Next(start, end + 1);
    }
    return array;
}

int MaxMinDiff(int[] array)
{
    return Math.Abs(array[0] - array[array.Length - 1]);
}

int[] array = GetArray(10, 0, 100);
System.Console.WriteLine("В массиве " + "[" + string.Join(", ", array) + "]");
System.Console.WriteLine($"разница между максимальным и минимальным элементом равна {MaxMinDiff(array)}");
