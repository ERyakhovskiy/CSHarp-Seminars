//  Семинар 3 МАССИВЫ-Функции:

// Теория:

// Задайте массив. Напишите программу, которая определяет
//  присутствует ли задананное число в массиве.
//  Программа должна выдать ответ: да/нет.

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

bool SearcheNum(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}


System.Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of array element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of affay element: ");
int max = Convert.ToInt32(Console.ReadLine());



int[] myArray = CreateRandomArray(size, min, max);
PrintArray(myArray);

System.Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(SearcheNum(myArray, num));



// Задайте массив из 10 элементов, заполненный числами из
// промежутка [-10, 10]. Замените отрицательные элементы на
// положительные, а положительные на отрицательные.

// РЕШЕНИЕ:

int[] CreateRandomArray(int size, int min, int max)  // Создает массив с рандомными эл-ми
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)   // Выводит элементы массива на консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int[] ChangeArray(int[] array)// метод который менят элементы в массиве (- на +) и (+ н а-)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}


System.Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of array element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of affay element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);  // 
PrintArray(myArray);

myArray = ChangeArray(myArray);// Перезаписывает измененный массив
PrintArray(myArray);



// Задача 3:
// найдете произведения пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т. д. Результат запишите в новый массив.

// РЕШЕНИЕ:


int[] CreateRandomArray(int size, int min, int max)  // Создает массив с рандомными эл-ми
{
    int[] array = new int[size];
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)   // Выводит элементы массива на консоль
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int[] CompositionArray (int[] array)
{
    int [] resultArray = new int[ array.Length / 2];  // Создаем новвый массив вдвое меньше
    for(int i = 0; i < resultArray.Length; i++) // цикл который перемножает попарно элементы и рез-т отправляет в новый массив
    {
       resultArray[i] = array[i] * array[array.Length - i - 1]; // новый массив resulatArray[i] в котором каждый эл-т произведение от двух элемнтов предыдущего массива
    }
    return resultArray;
}




System.Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input minimal value of array element: ");
int min = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Input maximal value of affay element: ");
int max = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(size, min, max);  // 
PrintArray(myArray);

PrintArray(CompositionArray(myArray));


