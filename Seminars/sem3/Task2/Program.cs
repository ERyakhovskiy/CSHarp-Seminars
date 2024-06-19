// ЗАДАНИЕ №2

// Задайте массив на 10 элементов, заполеннный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.
// Прмер:
// [1 -5 6] => [-1 5 -6]

// РЕШЕНИЕ:

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int[] ChangeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

System.Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal valey of array element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal valey of array element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);

myArray = ChangeArray(myArray);
PrintArray(myArray);