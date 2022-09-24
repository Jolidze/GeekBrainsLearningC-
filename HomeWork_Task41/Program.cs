//Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

/* 
//можно запомнить в массив
Console.WriteLine("Введите число M:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n]; 
int count = 0;

Console.WriteLine("Введите " + n + " чисел:" );

for (int i = 0; i < n; i++)
{
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > 0) count++;
}

Console.WriteLine("Вы ввели числа: " + string.Join(",", array ) );
Console.WriteLine("Среди них " + count + " более нуля");

*/

//а можно проще
Console.WriteLine("Введите число M:");
int m = Convert.ToInt32(Console.ReadLine());
int count = 0;

Console.WriteLine("Введите " + m + " чисел:" );

for (int i = 0; i < m; i++)
{
    int j = Convert.ToInt32(Console.ReadLine());
    if (j > 0) count++;
}

Console.WriteLine("Количество введенных чисел более нуля: " + count);