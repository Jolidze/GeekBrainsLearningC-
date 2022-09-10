//Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
//           и находит расстояние между ними в 3D пространстве.

Console.Write ("Введите координату х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе координату у1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе координату у1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите координату х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе координату у2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе координату у1: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double r = Math.Sqrt((  Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) ));

Console.WriteLine(r);

