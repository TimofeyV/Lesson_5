// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами (длина массива 5 элементов). 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// 
// [345, 897, 568, 234] -> 2


Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
RandNumberArray(array);
PrintArray(array);
FindEven(array);

void RandNumberArray(int[] array) //Заполение массива случайными числами
{
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array) //Фукнция печати массива
{
    Console.Write("Массив  -  [ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("] \n");
}

void FindEven(int[] array) //Фунция, которая покажет количество чётных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count ++;
        }
        
    }
    Console.WriteLine($"Количество четных чисел в массиве = {count}");
}