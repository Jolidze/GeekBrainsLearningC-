/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine()); 
int check = 2; //тут можно с 1 начинать, но строго говоря 1 все равно всегда нечетное )


if (N ==1 )Console.Write("Между 1 и 1 нет никаких чисел, соответственно нет и чётных чисел"); 
else
    if (N < 1) Console.Write("В диапазоне от " + N + " до 1 нет чётных чисел");
    else    
    {
        Console.Write("В диапазоне между 1 и " + N + " лежат такие чётные числа: ");
        while (check <= N)
        {
            if (check % 2 == 0)
            Console.Write(check + " ");
            check++;
        }    
    }
