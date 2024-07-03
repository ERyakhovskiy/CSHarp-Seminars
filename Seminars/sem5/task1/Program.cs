// ЗАДАЧА №1
// Задайте двумерный массив. Найдите элементы, у которых
// оба индекса четные, и замените эти эл-ты на их квадраты.
// Пример:
// 2 3 4 3
// 4 3 4 1 =>
// 2 9 5 4 

// 4 3 16 3
// 4 3 4 1
// 4 9 25 4

// Решение:

int[,] EvenNumsToQuad(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)// прохождение по столбцу(сверху вниз)
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // прохождение по строке(слева на право)
        {
            if(i % 2 == 0 && j % 2 == 0) // отлавливаем все эл-ты у которых оба индекса четные
            {
                matrix[i, j] = matrix[i, j] * matrix[i, j]; // подменяем значение эл-та на его квадрат
            }
        }
           
    }
    return matrix;
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
            Console.Write(matrix[i, j] + " ");// вывод строки в консоль
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

matrix = EvenNumsToQuad(matrix); // перезапишем созданную матрицу измененной(Эл-ты которой возвели в квадрат)
PrintMatrix(matrix);