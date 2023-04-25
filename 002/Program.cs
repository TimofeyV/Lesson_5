// Задача 36: Задайте одномерный массив, заполненный случайными числами (длина массива 5 элементов). 
// Найдите сумму элементов, стоящих на нечётных индексах (индексы с нуля).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
RandNumberArray(array);
PrintArray(array);
SummOdd(array);

void RandNumberArray(int[] array)// Заполение массива случайными числами
{
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = new Random().Next(-10000, 10001);
    }
}

void PrintArray(int[] array)// Фукнция печати массива
{
    Console.Write("Массив  -  [ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("] \n");
}

void SummOdd(int[] array)// Функция, которая находит сумму элементов, стоящих на нечётных индексах
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1)
        {
            summ += array[i];
        }
    }
    Console.WriteLine($"Сумма элементов, стоящих на нечётных индексах = {summ}");
}
