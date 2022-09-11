// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.Write("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());
int Number1 = Number; //ввожу промежуточное число для вычислений, чтоб сохранить исходное
int sum = 0;
int ost = 0;


while (Number1 > 0)
{
    ost = Number1 % 10;
    sum = sum + ost;
    Number1 = Number1 / 10;
}
    
Console.WriteLine("Сумма цифр числа " + Number + " = " + sum);


//Console.WriteLine(1 / 10);

