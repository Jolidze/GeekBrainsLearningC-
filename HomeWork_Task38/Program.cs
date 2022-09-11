//Задача 38: Задайте массив вещественных чисел. 
//           Найдите разницу между максимальным и минимальным элементами массива.

//метод для заполнения массива вещественными элементами
void FillArray (double[] ar38)
{
    int n = ar38.Length;
    int index = 0;
    while (index < n)
    {
        ar38[index] = Convert.ToDouble (new Random().Next(-10, 11) / 10.0);
        index ++;
    }
}

//метод для расчета разницы между макс и мин элементами массива
double Diff (double[] ar38)
{
    int len = ar38.Length;
    int ind = 0;
    double minEl = ar38[0];
    double maxEl = ar38[0];
    double diffAr38 = 0;

    //заглушка для массива из одного элемента, ну вдруг ;)
    if (len == 1) return diffAr38;

    //определим макс и мин элементы из первых двух чисел в массиве
    if (ar38[1] >= ar38[0]) 
    {
        maxEl = ar38[1];
        minEl = ar38[0];
    }
    else
        {
        maxEl = ar38[0];
        minEl = ar38[1];
    }

    //переберём элементы массива и переопределим минимум и максимум, за один проход
    for (ind = 2; ind < len; ind++)
    {
        if (ar38[ind] > maxEl) maxEl = ar38[ind];
        if (ar38[ind] < minEl) minEl = ar38[ind];

    }
    diffAr38 = maxEl - minEl;
    return diffAr38;
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine()); 
double[] MyArray38 = new double[n];
FillArray(MyArray38);
Console.WriteLine("Исходный массив: [" + string.Join("; ", MyArray38) + "]");
double d = Diff(MyArray38);
Console.WriteLine("Разница между максимальным и минимальным элемнтами массива равна = " + d); 

