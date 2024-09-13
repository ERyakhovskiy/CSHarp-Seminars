// Задача 1: 
// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива

// РЕШЕНИЕ

char[,] CreateCharsArray(int rows, int columns)
{
    char[,] charArray = new char[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            charArray[i, j] = (char)('a' + i * columns + j);
        }
    }
    return charArray;

}

void PrintArray(char[,] charArray)
{
    for(int i = 0; i < charArray.GetLength(0); i++)
    {
        for(int j = 0; j < charArray.GetLength(1); j++)
        {
            Console.Write(charArray[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

System.Console.WriteLine("Input number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

char[,] charArray = CreateCharsArray(rows, columns);
PrintArray(charArray);