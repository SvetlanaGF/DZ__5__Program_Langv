// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.Clear();
Console.WriteLine("Задача 36: Задать одномерный массив вещественных чисел.");
Console.WriteLine("Найти разницу между максимальным и минимальным элементами.");
Console.WriteLine();
int count = new Random().Next(2, 10);
Console.WriteLine($"В массиве задано элементов: {count}.");
double [] arr = new double [count];

void InputArray (double [] array)
// Получим элементы массива
{
    Random rand = new Random();              
        for (int i=0; i < array.Length; i++)
    {
        array [i] = rand.NextDouble()*100-50;
    }
}

void OutputArray (double[] array)
// Выведем массив на экран
{  
    Console.WriteLine($"Сформирован массив из {array.Length} элементов.");
    Console.Write($"[ ");
    for (int i=0; i<array.Length; i++)
    {
        Console.Write("{0,2:F2}", array[i]);
        if (i<(count-1)) Console.Write(", ");
    }
    Console.WriteLine(" ]");
}

InputArray (arr); // Получили массив
OutputArray (arr); // Вывод массива

double difference = 0;
double max = arr [1];
double min = arr [1];

void FindMinMax (double[] arr)
// Найдем минимальный и макксимальный элементы массива
{
    for (int i=1; i < arr.Length; i++)
    {
        if (arr [i] < min) min = arr[i];
        else 
             if (arr [i] > max) max = arr[i];
    }
    MetodDifference(max, min);
}

FindMinMax (arr);

double MetodDifference(double max, double min)
// Найдем разницу между максимальным и минимальным элементами массива
{
    difference = max - min;
    return difference;
}
Console.Write("Минимальный элемент массива: ");
Console.WriteLine("{0,2:F2}", min);
Console.Write("Максимальный элемент массива: ");
Console.WriteLine("{0,2:F2}", max);
Console.Write("Разница между ними: ");
Console.Write("{0,2:F2}", difference);