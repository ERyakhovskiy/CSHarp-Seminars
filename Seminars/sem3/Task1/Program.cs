// Семинар №3

// ЗАДАЧА №1:

// Задайтемассив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве. Программа
// должна выдать ответ: Да/Нет.
// Примеры:
// [1 3 4 19 3], 8 => Нет
// [-4 3 4 1], 3 => Да


// Решение:

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

bool SearchNum(int[] array, int num)
{
   for(int i = 0; i < array.Length; i++)
   {
    if(array[i] == num)
    {
        return true;
    }
   }
   return false;
}


System.Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal valey of array element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal valey of array element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);

System.Console.WriteLine("Input number: " );
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SearchNum(myArray, num));


