// Задача 31: Задайте массив из 12 элементов заполненный случайными значениями из диапазона [-9...9]. Найдите сумму отрицательных и положительных элементов массива.

// int[] array = new int[12];

// int resPositive = 0;
// int resNegative = 0;

// int i = 0;
// int length = array.Length;

// while (i < length)
// {
//     array[i] = new Random().Next(-9, 10);
//     Console.Write(array[i] + "\t");
//     if (array[i] > 0) resPositive += array[i];
//     else resNegative += array[i];
//     i++;
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма положительных чисел = {resPositive}, сумма отрицательных числе = {resNegative}");


// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] array = new int[12];

// int i = 0;
// int length = array.Length;

// while (true)
// {
//     array[i] = new Random().Next(-9, 10);
//     Console.Write(array[i] + "\t");

//     array[i] = array[i] * -1;
//     Console.Write(array[i] + "\t"+"\n");
//     i++;
// }




// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// Console.Write("Введите число для сравнения:  ");
// int val = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[5];
// int i = 0;
// int length = array.Length;
// bool flag = false;
// while (i < length)
// {
//     array[i] = new Random().Next(-9, 10);
//     Console.Write(array[i] + "\t");
    
//     if (array[i] == val)
//     {
//         flag = true;
//         break;
//     }
    
//     i++;
// }

// if (flag) Console.WriteLine("Да");
// else Console.WriteLine("Нет");

// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int[] array = new int[20];

// int i = 0;
// int length = array.Length;

// int count = 0;

// while (i < length)
// {
//     array[i] = new Random().Next(-90, 150);
//     Console.Write(array[i] + ", ");
    
//     if (array[i] > 10 && array[i] < 99)
//     {
//         count += 1;
//     }
    
//     i++;
// }
// Console.WriteLine();
// Console.WriteLine(count);





// Домашнее задание

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] array = new int[10];

// int i = 0;
// int length = array.Length;

// int count = 0;

// while (i < length)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write(array[i] + ", ");
    
//     if (array[i] %2 == 0)
//     {
//         count += 1;
//     }
    
//     i++;
// }
// Console.WriteLine();
// Console.WriteLine($"Массив содержит {count} четных чисел");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int[] array = new int[10];

// int sum = 0;

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-99, 99);
//     Console.Write(array[i] + ", ");
//     if (i %2 > 0)
//     {
//         sum = sum + array[i];
//     }
// }

// Console.WriteLine();
// Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");



// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] array = new int[10];


for (int i = 0; i < array.Length; i++)
{
    
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + ", ");

}

int max = array[0];
int min = array[0];

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}

Console.WriteLine();
Console.WriteLine($"{max} - {min} = {max-min}");