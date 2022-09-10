//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите положительное целое число: ");
int N = Convert.ToInt32(Console.ReadLine()); 
int check = 1;

while (N < 1)
{
    Console.Write("Ошибка ввода. Введите положительное целое число: ");
    N = Convert.ToInt32(Console.ReadLine()); 
}

Console.Write("Кубы чисел между 1 и " + N + " такие: ");
while (check <= N)
{
    Console.Write(Math.Pow (check, 3) + ", ");
    check++;
}    

