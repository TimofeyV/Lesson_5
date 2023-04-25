/*
Задача 4: Задайте массив из 10 случайных чисел из промежутка [-100, 100].
Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5 
*/

Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
RandNumberArray(array);
PrintArray(array);
SearchGap(array, 10, 99);

void RandNumberArray(int[] array) // Заполняем массив случайными элементами
{
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = new Random().Next(-100, 101);
    }
}

void PrintArray(int[] array) // Фукнция печати массива
{
    Console.Write("Массив  -  [ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("] \n");
}

void SearchGap(int[] array, int min,int max)// Фунция, которая находит количество чисел в промежутке
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] >= min && array [i] <= max)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [10,99] = {count}");
}