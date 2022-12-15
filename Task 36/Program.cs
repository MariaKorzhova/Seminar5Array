// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = FillArrayWithRandomNumbers(5, 0, 1000);
int SumOfOddPositions = SumOfOdd(arr);
System.Console.WriteLine("[" + string.Join (", ", arr) + "]");
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {SumOfOddPositions} ");


int[] FillArrayWithRandomNumbers (int size, int LeftRange, int RightRange)
{
    int[] TempArr = new int[size];
    for (int i = 0; i < TempArr.Length; i++)
    {
    TempArr[i] = new Random().Next(LeftRange, RightRange + 1);
    }  
    return TempArr;
}

int SumOfOdd (int[] TempArr)
{
    int SumOfOdd = 0;
    for (int i = 0; i < TempArr.Length; i++)
    {
        if (i%2 != 0)
        {
        SumOfOdd += TempArr[i];
        }
    }
    return SumOfOdd;
}


