// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();
Console.WriteLine("Задача 36: Задать одномерный массив случайными числами.");
Console.WriteLine("Найти сумму элементов, стоящих на нечётных позициях.");
Console.WriteLine();
//Console.Write("Введите количество элементов массива:  ");
int count = new Random().Next(1, 30);
//int count = int.Parse(Console.ReadLine());
Console.WriteLine($"В массиве задано элементов - {count}.");
int [] arr = new int [count];

void InputArray (int [] array)
// Получим элементы массива
{
        for (int i=0; i < array.Length; i++)
    {
        array [i] = new Random().Next(-100, 101);
    }
}

void OutputArray (int[] array)
// Выведем массив на экран
{  
    Console.WriteLine($"Сформирован массив из {array.Length} элементов.");
    Console.Write($"[ ");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if (i<(count-1)) Console.Write(", ");
    }
    Console.WriteLine(" ]");
}

InputArray (arr); // Получили массив
OutputArray (arr); // Вывод массива

int summOdd = 0;
void CountSummOdd (int[] arr)
// Определяем элементы, стоящие на нечётных позициях
{
    int temp = 0;
    for (int i=0; i < arr.Length; i++)
    {
        if (i %2 != 0) 
        {
            temp = arr[i];
            //Console.WriteLine($"temp = {temp} / i = {i}.");
            MetodSumm(temp);
        }
    }
    //return summOdd;
}
CountSummOdd (arr);

int MetodSumm(int temp)
// Суммируем элементы, стоящие на нечётных позициях
{
    summOdd = summOdd + temp;
    //Console.WriteLine($"перменная summOdd имеет значение {summOdd}.");
    return summOdd;
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях - {summOdd}.");