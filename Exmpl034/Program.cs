//Задача 34: Задайте массив 
//заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
Console.WriteLine("Задача 34: Заполнить массив случайными трехзначными числами.");
Console.WriteLine("Подсчитать количество четных элементов в созданном массиве.");
Console.WriteLine();
Console.Write("Введите количество элементов массива:  ");
int count = int.Parse(Console.ReadLine());
//Console.WriteLine($"В нашем массиве будет {count} элементов.");
int [] arr = new int [count];

// Объявление переменной для генерации чисел
Random rand = new Random(); 

// Получим элементы массива
void InputArray (int [] array)
{
    for (int i=0; i < array.Length; i++)
    {
        array [i] = rand.Next(100, 1000);
    }
}

// Выведем результаты на экран
void OutputArray (int[] array)
{  
    Console.WriteLine($"Получен массив из {array.Length} элементов.");
    Console.Write($"[ ");
    int count = array.Length;

    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]}");
        if (i<(count-1)) Console.Write(", ");
    }
    Console.WriteLine(" ]");
}

InputArray (arr); // Получили массив
OutputArray (arr); // Вывод массива

// Посчитаем количество четных элементов в массиве

int CountEven (int[] arr)
{
    int even = 0;
        for (int i=0; i < arr.Length; i++)
    {
        if (arr [i] %2 == 0) even = even+1;
    }
    return even;
}
Console.WriteLine($"В массиве {CountEven (arr)} четных элементов");
