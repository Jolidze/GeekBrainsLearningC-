//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

//метод для заполнения двумерного массива случайными вещественными числами
void FillMultiArrayRandomReal (double[,] m)
{
    for (int i = 0; i < m.GetLength(0); i++)
    {
        for (int j = 0; j < m.GetLength(1); j++)
        {
            m[i,j] = Convert.ToDouble (new Random().Next(-10, 10) / 10.0);
        }
        
    } 
}

//метод для печати двумерного массива на экран
void PrintMultiArray (double[,] matr)
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

Console.Clear();

Console.Write("Введите число строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matrix = new double[m, n]; //объявим двумерный массив = матрицу

FillMultiArrayRandomReal (matrix);
PrintMultiArray (matrix);