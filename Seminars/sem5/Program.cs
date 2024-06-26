// Семинар 5 Двумерные Масивы.
// Методы:
// Создание и заполднение двумерного Массива.

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
// 0 8 9 6
// 1 2 7 4
// 9 4 1 6


// Метод PrintMatrix

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
}

PrintMatrix(CreateRandomMatrix(4,6,0,9));  // выводит двумерный Массив(кол-во строк, кол-во столбцов, мин эл-т., макс. эл.)

