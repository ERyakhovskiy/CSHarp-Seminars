// Задание № 3

// Задайте двумерный массив их целых чисел. Сформируйте новый
// одномерный массив, состоящий из средних арифметических
// значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

// Решение

double[] SrAr(int [,] matrix)
{
    double[] result = new double[matrix.GetLength(0)]; // Размер создоваемого массива совподает с кол-м строк
    for(int i = 0; i < matrix.GetLength(0); i++)// прохождение по столбцу(сверху вниз)
    {
        int sum = 0; // обнуляет сумму после прохождения строки
        for(int j = 0; j < matrix.GetLength(1); j++) // прохождение по строке(слева на право)
        {
            sum += matrix[i, j]; // складываем все эл-ты строки
        }
        result[i] = (double)sum / matrix.GetLength(1); // обащаемся к новому массиву result по индексу [i] и записывае значение sum / кол-во эл-в в строке 
    }
    return result;
}

void PrintArray(double[] array)
{
    for(int i = 0; i < array.Length; i++)// прохождение по столбцу(сверху вниз)
    {
        System.Console.WriteLine(array[i] + " " );
    }
    Console.WriteLine("");
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
PrintArray(SrAr(matrix));// выводим одномерный массив со среднеарифмитческими эл-ми