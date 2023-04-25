// Задача 3: Задайте массив из 8 случайных чисел из промежутка [-9, 9].
// Напишите программу получает на вход число и определяет,
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


Console.Write("Введите размер массива: ");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];

Console.Write("Введите число, которое необходимо найти: ");
int findNumb = Convert.ToInt32(Console.ReadLine());

RandNumberArray(array);
PrintArray(array);
Console.WriteLine(FindItem(array, findNumb));

void RandNumberArray(int[] array)// Заполняем массив случайными элементами
{
    for (int i = 0; i < array.Length; i++)
    {
         array[i] = new Random().Next(-9, 10);
    }
}

void PrintArray(int[] array)//Функция печати массива
{
    Console.Write("Массив  -  [ ");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("] \n");
}

string FindItem(int[] array, int findNumb)//Функция для нахождения числа в массиве
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == findNumb)
        {
            return $"Число {findNumb} присутствует в массиве, его индекс = {i}";
        }
    }
    return $"Число {findNumb} отсутсвует в массиве"; 
}