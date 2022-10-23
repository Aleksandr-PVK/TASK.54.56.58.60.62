﻿// Задача 54: Программа, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
void Task54()
{
    Console.WriteLine("Введите количество строк:");
    int linesVol = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов:");
    int columnsVol = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[linesVol, columnsVol];
    FillArrayRandomNumbers(numbers);
    Console.WriteLine();
    Console.WriteLine("Массив до изменения:");
    PrintArray(numbers);

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {
                if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                {
                    int temp = 0;
                    temp = numbers[i, z];
                    numbers[i, z] = numbers[i, z + 1];
                    numbers[i, z + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
    Console.WriteLine("Массив с упорядоченными значениями:");
    PrintArray(numbers);

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}
// Задача 56: Задаю прямоугольный двумерный массив и программа находит строку с наименьшей суммой элементов.
void Task56()
{
    Console.WriteLine("Введите размер квадратного массива:");
    int massVol = Convert.ToInt32(Console.ReadLine());
    int[,] numbers = new int[massVol, massVol];
    FillArrayRandomNumbers(numbers);
    PrintArray(numbers);
    int minsum = Int32.MaxValue;
    int indexLine = 0;

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            sum = sum + numbers[i, j];
        }
        if (sum < minsum)
        {
            minsum = sum;
            indexLine++;
        }
    }

    Console.WriteLine("Строка с наименьшей суммой елементов под номером: " + (indexLine) + ", с суммой елементов равной: " + (minsum));

    void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(0, 10);
            }
        }
    }

    void PrintArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.Write("]");
            Console.WriteLine("");
        }
    }
}