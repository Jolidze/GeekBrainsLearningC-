//Задача 52. Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

//метод для заполнения двумерного массива случайными числами
void FillRandomMultiArray (int[,] matri)
{
    for (int i = 0; i < matri.GetLength(0); i++)
    {
        for (int j = 0; j < matri.GetLength(1); j++)
        {
            matri[i,j] = new Random().Next(1, 10); //полуинтервал [1, 10) 
        }
    } 
}

//метод для печати двумерного массива на экран
void PrintMultiArray (int[,] matr)
{
    Console.WriteLine(); 
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} \t"); //сначала выведем все столбцы одной строки, элементы через пробел
        }
        
        Console.WriteLine(); //каждую следующую строку матрицы выведем на новой строке

    } 
}


//метод для расчета среднего арифметического всех элементов в каждом столбце
void AvgMultiArrayColumns (int[,] m)
{
    double sum = 0;
    double count = 0;
    for (int j = 0; j < m.GetLength(1); j++) //во внешнем массиве перебираем столбцы
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            sum = sum + m[i,j];
            count++;
        }  

        Console.WriteLine($"Среднее арифметическое столбца {j+1} = {sum/count}"); 
        sum = 0;
        count = 0;
 
    }  
}


Console.Clear();

Console.Write("Введите число строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n]; //объявим двумерный массив
FillRandomMultiArray(matrix);
PrintMultiArray(matrix);

AvgMultiArrayColumns(matrix);




