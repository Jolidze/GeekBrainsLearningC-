// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
//            и проверяет, является ли этот день выходным.


Console.Clear(); //Очистка консоли, для красоты
Console.Write ("Введите цифровое обозначение дня недели: ");
int dw = Convert.ToInt32(Console.ReadLine());

while (dw < 1 || dw > 7)
{
    Console.WriteLine ("Не верное число");
    Console.WriteLine ("Введите цифровое обозначение дня недели: ");
    dw = Convert.ToInt32(Console.ReadLine());
}

if (dw > 5)
    Console.WriteLine ("Да, это выходной");
else
    Console.WriteLine ("Нет, это не выходной");