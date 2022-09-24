//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

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


//метод поиска элемента в двумерном массиве по его позиции
string FindElementInMultiArray (int[,] multiArray, int row, int col)
{
    if ( row - 1 < 0 || row > multiArray.GetLength(0) || col -1 < 0 || col > multiArray.GetLength(1) ) 
    {
        return "Такого элемента нет ";
    }
    else return "искомый элемент: " + Convert.ToString(multiArray[row-1, col-1]);
}

Console.Clear();

Console.Write("Введите число строк массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n]; //объявим двумерный массив
FillRandomMultiArray(matrix);
PrintMultiArray(matrix);

Console.Write("Задайте номер строки для поиска элемента: ");
int mm = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте номер столбца для поиска элемента: ");
int nn = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindElementInMultiArray(matrix, mm, nn));



