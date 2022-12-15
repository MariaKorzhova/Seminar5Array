// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76



double[] arr = FillArrayWithRandomNumbers(5, 0, 5);
MaxAndMin(arr, out double Max, out double Min);
double DeductionMaxMin = Max - Min;

System.Console.WriteLine("[" + string.Join (", ", arr) + "]");
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива {Math.Round(DeductionMaxMin, 3)} ");

double[] FillArrayWithRandomNumbers (int size, int LeftRange, int RightRange)
{
    double[] TempArr = new double[size];
    for (int i = 0; i < TempArr.Length; i++)
    {
    TempArr[i] = Math.Round(new Random().Next(LeftRange, RightRange) + new Random().NextDouble(), 3);
    }  
    return TempArr;
}

void MaxAndMin (double[] TempArr, out double Max, out double Min)
{
    Min = TempArr[0];
    Max = TempArr[0];
    for (int i = 0; i < TempArr.Length; i++)
    {
        if (TempArr[i] > Max) 
        {
            Max = TempArr[i];
        }
        if (TempArr[i] < Min) 
        {
            Min = TempArr[i];
        }
    }
}



