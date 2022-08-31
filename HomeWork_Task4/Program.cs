/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.Write("Введите первое число: ");
int m1 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите второе число: ");
int m2 = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите третье число: ");
int m3 = Convert.ToInt32(Console.ReadLine()); 

/*
//Решение через Math
int max1 = Math.Max(m1,m2);
int max = Math.Max(max1,m3);
Console.WriteLine ("Максимальное из введенных чисел = " + max);
*/

//решение через ветвление
int max; 
if (m2 > m1) 
    if (m3 > m2) max = m3;
    else max = m2;
else
    if (m3 > m1) max = m3;
    else max = m1;

Console.WriteLine ("Максимальное из введенных чисел = " + max);
