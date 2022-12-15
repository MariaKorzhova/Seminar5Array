// Задайте массив, заполненный случайными положительными
// трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = FillArrayWithRandomNumbers(4, 100, 999);
int EvenNumbers = EvenNum(arr);
System.Console.WriteLine("[" + string.Join (", ", arr) + "]");
System.Console.WriteLine($"Количество чётных чисел равно {EvenNumbers} ");



int[] FillArrayWithRandomNumbers (int size, int LeftRange, int RightRange)
{
    int[] TempArr = new int[size];
    for (int i = 0; i < TempArr.Length; i++)
    {
    TempArr[i] = new Random().Next(LeftRange, RightRange + 1);
    }  
    return TempArr;
}

int EvenNum (int[] TempArr)
{
    int Even = 0;
    for (int i = 0; i < TempArr.Length; i++)
    {
        if (TempArr[i]%2 == 0)
        {
        Even += 1;
        }
    }
    return Even;
}