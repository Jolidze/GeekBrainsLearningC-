// Пример 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//            Напишите программу, которая покажет количество чётных чисел в массиве.


void FillArray (int[] ar)
{
    int n = ar.Length;
    int index = 0;
    while (index < n)
    {
        ar[index] = new Random().Next(100, 1000);
        index ++;
    }
}


int CountEvenElements (int[] arr34)
{
    int count = 0;
    int check = -1;
    for (int i = 0; i < arr34.Length; i++)
    {
        check = arr34[i] % 2;
        if (check == 0 ) count++;
    }
    return count;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); 
int[] MyArray34 = new int[n];
FillArray(MyArray34);
Console.WriteLine("Исходный массив: [" + string.Join(",", MyArray34) + "]");
int countEven = CountEvenElements(MyArray34);
Console.WriteLine("Количество чётных чисел в массиве = " + countEven); 
