//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] getArray(int size, int start, int end)
{
    int[] array = new int[size];
    Random rng = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rng.Next(start, end + 1);
    }
    return array;
}

int positiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result++;
        }
    }
    return result;
}

int[] array = getArray(10, 100, 999);
System.Console.WriteLine("В массиве " + "[" + string.Join(", ", array) + "]");
System.Console.WriteLine(positiveNumbers(array) + " положительных чисел");