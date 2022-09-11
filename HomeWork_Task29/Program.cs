//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];
int i = 0; 

//через for почему то не так сработало, сделала через while, подскажите пож в чем ранзица
// for (i = 0; i < 8; i++)
//     Console.WriteLine("Введите элемент массива с индексом" + i);
//     array[i] = Convert.ToInt32(Console.ReadLine());

while (i < 8)
{
    Console.Write("Введите элемент массива с индексом " + i + " :");
    array[i] = Convert.ToInt32(Console.ReadLine());
    i++;
}


Console.WriteLine("Вы ввели такой массив: [" + string.Join(",", array ) + "]");