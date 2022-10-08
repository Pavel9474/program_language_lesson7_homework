//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
double GetDoubleRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1)+ new Random().NextDouble();
}
void FillArray(double[,] arr, int minValue, int maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetDoubleRandomValue(minValue,maxValue);
        }
    }
}
void PrintArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(Math.Round(arr[i,j],1) + " ");
        }
        Console.WriteLine();
    }
}
double[,] InitializateArray(int m, int n)
{
    return new double[m,n];
}
int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
double[,] array = InitializateArray(m,n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array,minValue,maxValue);
PrintArray(array);