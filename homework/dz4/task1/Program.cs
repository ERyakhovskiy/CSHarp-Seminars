// ДЗ 4 Задание 1:

//  Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

// РЕШЕНИЕ



// System.Console.WriteLine("Input integer number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if(num = q)
// {
//     break;
// }
// int num2 = num;


// while(num > 0)
// {
//     System.Console.WriteLine("Input integer number: ");
//     int num3 = Convert.ToInt32(Console.ReadLine());
    
// }

    //   

// Задача 2:
//  Задайте массив заполненный случайными трёхзначными числами. +
//  Напишите программу, которая покажет количество чётных чисел в массиве. 

// РЕШЕНИЕ:

// int[] CreateRandomArray(int size)

// {
//     int[] array = new int[size];
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(100, 999 + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int CountEvenNumber(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             count++;
//         }

//     }
//     return count;
// }



// System.Console.WriteLine("Input size of array");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size);
// PrintArray(myArray);
// int[] array = CreateRandomArray(size); // ссылка на участок в памяти(Заполенинный методом "InputArray" массив, передаем переменной "int[] arr")
// System.Console.WriteLine(CountEvenNumber(array));

//!!!!!!!!!!!!!!!РАБОТАЕТ НЕ КОРРЕКТНО, неправильно считает!!!!!

// Задача 3:
//  Напишите программу, которая перевернёт одномерный массив 
//  (первый элемент станет последним, второй – предпоследним и т.д.)


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

int[] ChengeArray(int[] array)
{
    int[] mirrorArray = new int[array.Length];
    for (int i = 0; i < mirrorArray.Length; i++)
    {
        mirrorArray[i] = array[array.Length - i - 1];

    
    }
    return mirrorArray; 
}
System.Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size);
PrintArray(myArray);


// int[] myArray2 = ChengeArray(size);
// PrintArray(myArray2);



// myArray = ChengeArray(myArray);
// PrintArray(myArray);

PrintArray(ChengeArray(myArray));
