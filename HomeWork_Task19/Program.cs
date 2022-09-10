//Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//           является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int palin = Convert.ToInt32(Console.ReadLine()); 

while (palin < 10000 || palin > 99999)
{
    Console.Write("Введите пятизначное число: ");
    palin = Convert.ToInt32(Console.ReadLine()); 
}

int x1 = palin / 10000; //первая цифра числа
int x2 = palin / 1000 % 10; //вторая
int x4 = palin % 100 / 10; //четвертая
int x5 = palin % 10; //пятая

Console.WriteLine("x1 = " + x1 + ", x2 = " + x2 + ", x4 = " + x4 + ", x5 = " + x5);
