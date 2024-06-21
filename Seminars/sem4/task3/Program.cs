// ЗАДАНИЕ №3 

// Заполните массив на N (вводится с консоли,не более 8)
// случайный чисел от 0 до 9.
// Сформеруйте целое число которое будет состоять из цифр массива.
// Старший разряд числа находится на 0-м индексе, младший - на последнем.
// ПРИМЕР:
// [1 3 2 4 2 3] => 132423
// [2 3 1] => 231

// РЕШЕНИЕ

int[] CreateRandomArray(int size)

{
    int[] array = new int [size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 9 + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int NumberOfArray (int[] array)
{
    int number = 0;
    for(int i = 0; i < array.Length; i++)
    {
        number += array[i] * (int)Math.Pow(10, array.Length-i-1);
    }
    return number;
}

System.Console.WriteLine("Input size of array");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size); 
int result = NumberOfArray(myArray);
PrintArray(myArray);
System.Console.WriteLine(result);

