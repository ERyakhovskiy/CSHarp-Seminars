﻿// Задача № 2

// Задайте двухмерный массив. Найдите сумму эл-в,
// находящихся на главной диогонали (с индексами (0, 0); (1,1))
// и т.д.
// Пример
// 2 3 4 3
// 4 3 4 1 = > 2 + 3 + 5 = 10
// 1 9 5 4

// Решение


int SomOfMainDiagonal(int[,] matrix )
{
    int sum = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)// прохождение по столбцу(сверху вниз)
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // прохождение по строке(слева на право)
        {
           if(i == j) // выставили условия, что оба индекса равны([0,0][1,1][2,2] и.т.д.)
           {
                sum += matrix[i, j]; // сложили сумму всех диогональных эл-ов
           }
        }
    }
    return sum;
}


int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random random = new Random();
    for(int i = 0; i < rows; i++)// прохождение по столбцу(сверху вниз)
    {
        for(int j = 0; j < columns; j++) // прохождение по строке(слева на право)
        {
            matrix[i, j] = random.Next(min, max + 1);// генирирует целочисленное значение в заданном диапазоне
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)// прохождение по столбцу(сверху вниз)
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // прохождение по строке(слева на право)
        {
            Console.Write(matrix[i, j] + " ", ConsoleColor.Green);// вывод строки в консоль
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


System.Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input min of matrix: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input max of matrix: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateRandomMatrix(rows, columns, min, max); // матрицу созданную функцией CreateMatrix запишем в переменную int[,] matrix
PrintMatrix(matrix); // выводит созданную матрицу

System.Console.WriteLine(SomOfMainDiagonal(matrix));