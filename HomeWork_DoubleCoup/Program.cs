// Задача Двойной переворот
//https://acmp.ru/asp/do/index.asp?main=task&id_course=1&id_section=5&id_topic=114&id_problem=700

/*
Дана последовательность натуральных чисел 1, 2, 3, ..., N. 
Необходимо сначала расположить в обратном порядке часть этой последовательности 
от элемента с номером A до элемента с номером B, 
а затем от C до D.

Входной файл INPUT.TXT содержит 5 натуральных чисел N, A, B, C и D (A ≤ B; C ≤ D; 1 ≤ A, B, C, D ≤ N ≤ 1000).

В выходной файл OUTPUT.TXT выведите полученную последовательность, полученную в результате двойного переворота.
*/

//примечание: помню что Вы говорили не заморачиваться на интерфейсе ввода-вывода, потому буду работать с консолью, без файлов


//метод для заполнения массива последовательностью натуральных чисел
void FillArrayNatural (int[] arrayNatural)
{
    int n = arrayNatural.Length;
    int indexNatural = 0;

    while (indexNatural < n)
    {
        arrayNatural[indexNatural] = indexNatural + 1;
        indexNatural ++;
    }
}

//метод для "разворота" части массива
void Coup (int[] arToCoup, int coupFrom, int coupTo)
{
    int a = coupFrom - 1; //индекс элемента А (C)
    int b = coupTo - 1; //индекс элемента B (D)

    //проверим нужно ли вообще что-то разворачивать
    if (b == a) return;

    //определим "серединку" разворачиваемого участка (в текущем контексте четное\нечетное количество элементов не важно)
    int seredinka = (b + a) / 2;
    int p = -1; //промежуточная переменная для выполнения разворота
    int incr = 0; //промежуточная переменная для выполнения разворота

    //развернём заданную часть массива
    for (int j = a; j <= seredinka; j++)
    {
        p = arToCoup[a + incr];
        arToCoup[a + incr] = arToCoup[b - incr];
        arToCoup[b - incr] = p;
        incr++;

    }
}

//метод для подписи работ
void Author ()
{
    System.Console.WriteLine ("Автор: Григорьева Юлия, группа 3130");
}

//основная программа:
Console.Clear();

Console.Write("Введите количество элементов массива (от 1 до 1000): ");
int N = Convert.ToInt32(Console.ReadLine()); 

//проверка корректности ввода N
while (N < 1 || N > 1000)
{
    Console.Write("Не верно. Введите количество элементов массива (от 1 до 1000): ");
    N = Convert.ToInt32(Console.ReadLine()); 
}

//заполнение массива = последовательности натуральных чисел
int[] MyArrayNatural = new int[N];
FillArrayNatural(MyArrayNatural);
Console.WriteLine("Исходный массив: [" + string.Join(",", MyArrayNatural) + "]");
Console.WriteLine();

Console.Write("Введите A (от 1 до " + N  + "): ");
int A = Convert.ToInt32(Console.ReadLine()); 

//проверка корректности ввода A
while (A < 1 || A > N)
{
    Console.Write("Не верно. Введите A (от 1 до " + N  + "): ");
    A = Convert.ToInt32(Console.ReadLine()); 
}

Console.Write("Введите B (от " + A + " до " + N  + "): ");
int B = Convert.ToInt32(Console.ReadLine()); 

//проверка корректности ввода B
while (B < A || B > N)
{
    Console.Write("Не верно. Введите B (от " + A + " до " + N  + "): ");
    B = Convert.ToInt32(Console.ReadLine()); 
}

//первый разворот 
Coup(MyArrayNatural, A, B);
Console.WriteLine("Массив после первого разворота: [" + string.Join(",", MyArrayNatural) + "]");
Console.WriteLine();


Console.Write("Введите C (от 1 до " + N  + "): ");
int C = Convert.ToInt32(Console.ReadLine()); 

//проверка корректности ввода C
while (C < 1 || C > N)
{
    Console.Write("Не верно. Введите C (от 1 до " + N  + "): ");
    C = Convert.ToInt32(Console.ReadLine()); 
}

Console.Write("Введите D (от " + C + " до " + N  + "): ");
int D = Convert.ToInt32(Console.ReadLine()); 

//проверка корректности ввода D
while (D < C || D > N)
{
    Console.Write("Не верно. Введите D (от " + C + " до " + N  + "): ");
    D = Convert.ToInt32(Console.ReadLine()); 
}

//второй разворот 
Coup(MyArrayNatural, C, D);
Console.WriteLine("Массив после второго разворота: [" + string.Join(",", MyArrayNatural) + "]");
Console.WriteLine();

Author ();
