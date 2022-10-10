// Напишите программу для умножения двух двумерных массивов (есть ограничения в размерностях)
int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}
void FillArray(int[,] arr, int minValue, int maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(minValue,maxValue);
        }
    }
}
void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine(); //Добавил чтобы вывод был красивее
}
int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}
int[,] MultMatrixByMatrix(int[,] arr1, int[,] arr2)
{
    int[,] MultMatrix=new int[arr1.GetLength(0),arr2.GetLength(1)];
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            MultMatrix[i,j]=0;
            for (int k = 0; k < arr1.GetLength(1); ++k)
            {
                MultMatrix[i,j]+=arr1[i, k]*arr2[k,j];
            }     
        }
        }
            return MultMatrix;
    }
//КОД ОСНОВНОЙ ПРОГРАММЫ
int m = GetNumberFromConsole("Введите размерность массива m");
int n = GetNumberFromConsole("Введите размерность массива n");
int[,] array1 = InitializateArray(m,n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array1,minValue,maxValue);
PrintArray(array1);
int[,] array2 = InitializateArray(m,n);
FillArray(array2,minValue,maxValue);
PrintArray(array2);
PrintArray(MultMatrixByMatrix(array1,array2));