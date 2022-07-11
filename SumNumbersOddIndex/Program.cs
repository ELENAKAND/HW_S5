/*
Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
int[] GetArray(int dimension)
{
    int[] arr = new int [dimension];
    Random randomizer = new Random();
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = randomizer.Next(10, 100);
    }
return arr;
}
void PrintArray(int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void SumOddIndex(int[] array)
{   
    int sum = 0;
    for (int i=1; i<array.Length; i+=2)//i=i+2
    {
        sum += array[i];
    }
Console.WriteLine($"Сумма чисел в нечетных индексах равна {sum}");
}


int[] array = GetArray(10);
PrintArray(array);
Console.WriteLine();
SumOddIndex(array);