



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



