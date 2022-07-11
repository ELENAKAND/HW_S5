/*
Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/
double[] GetArray(int dimension)//вещественные числа
{
    double[] arr = new double [dimension];
    Random randomizer = new Random();
    for (int i=0; i<arr.Length; i++)
    {
        arr[i] = randomizer.Next(-10, 10);
    }
return arr;
}
void PrintArray(double [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
void FindMinMaxDifference(double[]array)
{
    double max = array[0];
    double min = array[0];
    for (int i=0; i<array.Length; i++)
    {
        if (array[i]>max)
        max = array[i];
        if (array[i]<min)
        min = array[i];
    }
Console.WriteLine($"Разница между min и max равна {max-min}");
}
double[] array = GetArray(10);
PrintArray(array);
Console.WriteLine();
FindMinMaxDifference(array);

