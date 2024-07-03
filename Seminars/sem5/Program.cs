// Семинар 5 Двумерные Масивы.
// Методы:
// Создание и заполднение двумерного Массива.

int[,] CreateRandomMatrix(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // Создали 2хМер. Массив matrix и задали ему размер(все эл-ты равны 0)
    Random random = new Random(); // создали объект класса Random и назвали его random
    for(int i = 0; i < rows; i++)// прохождение по столбцу(сверху вниз)
    {
        for(int j = 0; j < columns; j++) // прохождение по строке(слева на право)
        {
            matrix[i, j] = random.Next(min, max + 1);// медот Next генирирует целочисленное значение в заданном диапазоне
        }
    }
    return matrix; // вернули заполненный массив matrix
}
// 0 8 9 6
// 1 2 7 4
// 9 4 1 6


// Метод PrintMatrix. Выводит матрицу на экран

void PrintMatrix(int[,] matrix) // в качестве аргумента записали 2м-й массив matrix
{
    for(int i = 0; i < matrix.GetLength(0); i++)// возвращает кол-во строк(сверху вниз)
    {
        for(int j = 0; j < matrix.GetLength(1); j++) // возвращает кол-во столбцов(слева на право)
        {
            Console.Write(matrix[i, j] + " ", ConsoleColor.Green);// вывод строки в консоль(write чтобы вывести в стрку)
        }
        Console.WriteLine();
    }
}

PrintMatrix(CreateRandomMatrix(4,6,0,9));  // выводит двумерный Массив(кол-во строк, кол-во столбцов, мин эл-т., макс. эл.)

