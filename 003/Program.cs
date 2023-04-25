// Задача 38: Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов).
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
RandNumberArray(array);
PrintArray(array);
DiffMinMax(array);

void RandNumberArray(int[] array)// Заполение массива случайными числами
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

void DiffMinMax(int[] array) // Функия, которая находит разницу между максимальным и минимальным элементов массива
{
    int max = -101;
    int min = 100;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        }
        else if(array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine($"Маскимальный элемент массива - {max}");
    Console.WriteLine($"Минимальный элемент массива - {min}");
    Console.WriteLine($"Разница между максимальный и минимальным элементов = {max - min}");
}


