// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine()); 
int numVStepeni = A;
Console.Write("Введите натуральную степень: ");
int B = Convert.ToInt32(Console.ReadLine()); 

while (B < 1)
{
    Console.Write("Ошибка ввода. Введите натуральное число для степени: ");
    B = Convert.ToInt32(Console.ReadLine()); 
}

for (int i = 2; i <= B; i++)
    numVStepeni = numVStepeni * A;  //накапливаю итог в umVStepeni, каждую итерацию умножая его на исходное число А

Console.WriteLine("Число " + A + " в степени " + B +" = " + numVStepeni);