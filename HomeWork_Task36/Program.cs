// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//            Найдите сумму элементов, стоящих на нечётных позициях.

//метод для заполнения массива элементами
void FillArray (int[] ar)
{
    int n = ar.Length;
    int index = 0;
    while (index < n)
    {
        ar[index] = new Random().Next(-10, 11);
        index ++;
    }
}

//метод для подсчета суммы элементов размещенных на нечетных индексах массива
int SumOdd (int[] arr36)
{
    int sum = 0;
    int checkOdd = -1;
    for (int i = 0; i < arr36.Length; i++)
    {
        checkOdd = i % 2;
        if (checkOdd != 0 ) sum = sum + arr36[i];
    }
    return sum;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int[] MyArray36 = new int[n];
FillArray(MyArray36);
Console.WriteLine("Исходный массив: [" + string.Join(",", MyArray36) + "]");
int SummaOdds = SumOdd(MyArray36);
Console.WriteLine("Сумма элементов стоящих на нечетных позициях массива = " + SummaOdds); 
