//Задача 34: Задайте массив 
//заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Задача 34: Заполнить массив случайными трехзначными числами.");
Console.WriteLine("Подсчитать количество чётных элементов в созданном массиве.");
Console.WriteLine();
Console.Write("Введите количество элементов массива:  ");
int count = int.Parse(Console.ReadLine());
int [] arr = new int [count];

// Объявление переменной для генерации чисел
//Random rand = new Random(); 

void InputArray (int [] array)
// Получим элементы массива
{
        for (int i=0; i < array.Length; i++)
    {
        array [i] = new Random().Next(100, 1000);
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

int CountEven (int[] arr)
// Посчитаем количество чётных элементов в массиве
{
    int even = 0;
        for (int i=0; i < arr.Length; i++)
    {
        if (arr [i] %2 == 0) even++;
    }
    return even;
}
Console.WriteLine($"В массиве чётных элементов - {CountEven (arr)}.");
