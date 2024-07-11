



// Задача 1: 
// Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.

// Решение:

//  bool multipicity (int num)
//  {
//     if(num % 7 == 0 && num % 23 == 0)
//     {
//         return true;
//     }
//     return false;
//  }

// void result (int num)
// {
//     if(multipicity(num))
//     {
//         Console.WriteLine("ДА");
//     }
//     else
//     {
//         Console.WriteLine("НЕТ");
//     }
// }

// System.Console.WriteLine("Input number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// result(num);



// Задача 2: 
// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
// в которой находится эта точка.


// System.Console.Write("Input cordinatie x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input cordinatie y: ");
// int y = Convert.ToInt32(Console.ReadLine());


// if (x > 0 && y > 0)
// {
//     Console.Write($"I quad ");
// }
// if (x < 0 && y > 0)
// {
//     Console.Write($"II quad ");
// }
// if (x < 0 && y < 0)
// {
//     Console.Write($"III quad ");
// }
// if (x > 0 && y < 0)
// {
//     Console.Write($"IV quad ");
// }




// Задача 3:
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99]
// и показывает наибольшую цифру числа.

// РЕШЕНИЕ:


// bool Number(int n)
// {
//     if(n > 9 && n < 100)
//     {
//         return true;
//     }
//     return false;
// }

// void MaxNumber (int n)
// {
//     if(Number(n))
//     {
//         int units = n % 10;
//         int tens = n / 10;
//         int max = units;
//         if(tens > units)
//         {
//             System.Console.WriteLine(tens);
//         }
//         else
//         {
//             System.Console.WriteLine(units);
//         }
//     }

// }

// System.Console.WriteLine("Input number: " );
// int n = Convert.ToInt32(Console.ReadLine());
// MaxNumber(n);

// Задача 4:

//  Напишите программу, которая на вход принимает натуральное число N,
//   а на выходе показывает его цифры через запятую.
// Пример вы найдете в конце презентации к семинару.

// РЕШЕНИЕ:

// System.Console.WriteLine("Input N: ");
// int N = Convert.ToInt32(Console.ReadLine());

// if(N < 10)
// {
//     System.Console.WriteLine(N);
// }
// else
// {
//     while(N > 0)
//     {
//         int currentDigit = N % 10;
//         N /= 10;
//         if(N > 0)
//         {
//             System.Console.Write(currentDigit + (","));
//         }
//         else
//         {
//             Console.Write(currentDigit);
//         }
//     }   
// }


// ДЗ 4 Задание 1:

//  Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, 
// сумма цифр которого чётная.

// РЕШЕНИЕ от преподователя

bool IsTrue(string value)
{
    if(value == "q" ) return false;
    int num = Convert.ToInt32(value);
    int sum = 0;
    while(num > 0)
    {
        sum += num % 10;
        num /=10;
    }
    if(sum % 2 == 0)
    {
        return false;
    } 
    return true;
}

bool work = true;
while(work) // цикл проверяет является ли work = true
{
    string value = Console.ReadLine();
    if(IsTrue(value))
    {
        System.Console.WriteLine("!!!");
    }
    else
    {
        System.Console.WriteLine("???");
        work = false;
    }
}


// мои попытки

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


// int[] CreateRandomArray(int size)

// {
//     int[] array = new int [size];
//     Random random = new Random();
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = random.Next(0, 9 + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int[] ChengeArray(int[] array)
// {
//     int[] mirrorArray = new int[array.Length];
//     for (int i = 0; i < mirrorArray.Length; i++)
//     {
//         mirrorArray[i] = array[array.Length - i - 1];

//         i = i + 1;
//     }
//     return mirrorArray; 
// }
// System.Console.WriteLine("Input size of rray: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size);
// PrintArray(myArray);


// // int[] myArray2 = ChengeArray(size);
// // PrintArray(myArray2);



// // myArray = ChengeArray(myArray);
// // PrintArray(myArray);

// PrintArray(ChengeArray(myArray));
