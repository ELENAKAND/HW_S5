/*
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
int[] GetArray(int dimension)
{
    int[] arr = new int [dimension];
    Random randomizer = new Random();
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = randomizer.Next(100, 1000);
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
void EvenNumbers(int[]array)
{
    int count = 0;//считает случаи выполнения условия
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]%2==0)
        count++;
    }
    Console.WriteLine($"Количество положительных чисел в массиве равно {count}");
}



Console.WriteLine("Введите размер массива");
int dim = int.Parse(Console.ReadLine());
int[] array = GetArray(dim);
PrintArray(array);
Console.WriteLine();
EvenNumbers(array);

