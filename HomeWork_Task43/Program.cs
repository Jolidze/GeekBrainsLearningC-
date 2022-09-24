
//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения: b1, k1, b2, k2");
float b1 = Convert.ToInt32(Console.ReadLine());
float k1 = Convert.ToInt32(Console.ReadLine());
float b2 = Convert.ToInt32(Console.ReadLine());
float k2 = Convert.ToInt32(Console.ReadLine());

if (k1 == k2)
{
    if (b1 == b2)  Console.WriteLine("Прямые совпадают, все точки являются общими");
    else Console.WriteLine("Прямые параллельны, нет общих точек");
}

else 
{
    float x = (b2 - b1) / ( k1 - k2); //выразила х
    float y = k1 * x + b1; //подставила х
    Console.WriteLine("Прямые пересекаются в точке (" + x + " , " + y + ")");
}





