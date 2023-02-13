//  Задача 36: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] GetArray(int size, int start, int end)
{
    int[] array = new int[size];
    var rng = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rng.Next(start,end+1);
    }
    return array;
}

int SumOfElements(int [] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i%2==1)
        {
            result += array[i];
        }
    }
    return result;
}

int[] array = GetArray(10,-100,100);
System.Console.WriteLine("B массиве "+"["+ string.Join(", ",array)+"]");
System.Console.WriteLine($"сумма элементов c нечётным индексом равна {SumOfElements(array)}");
