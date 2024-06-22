//методы-функции


// int Pow (int n)
// {
//     return n * n;
// }

// void Pow2(int n)
// {
//     System.Console.WriteLine($"Quad of {n} -> {n * n}");
// }


// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Pow2(a);


//Задание №1



// bool IsThreeDigit(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// void DeleteSecondDigit(int num)

// {
//     if(IsThreeDigit(num))
//     {
//         int ed = num % 10;
//         int sot = num / 100;
//         Console.WriteLine(ed + sot * 10);
//     }
//     else
//     {
//         System.Console.WriteLine("You input no three-Digit number");
    
//     }
// }



// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// DeleteSecondDigit(a);


//Задание №2


// bool IsThreeDigit(int num)
// {
//     if (num > 99 && num < 1000)
//     {
//         return true;
//     }
//     return false;
// }

// void SecondToThirdPower(int num)
// {
//     if(IsThreeDigit(num))
//     {
//         int ed = num % 10;
//         int des = num / 10 % 10;
//         Console.WriteLine(Math.Pow(des, ed));
//     }
//     else
//     {
//         System.Console.WriteLine("You input no three-Digit number");
    
//     }
// }

// System.Console.WriteLine("Input number: ");
// int a = Convert.ToInt32(Console.ReadLine());
// SecondToThirdPower(a);


//Задание №3

// bool Multiplicity(int x,int y)

// {
//     if(x % y ==0)
//     {
//         return true;
//     }
//     return false;
// }

// void Result(int x, int y)
// {
//     if (Multiplicity(x,y))
//     {
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine($"нет,{x % y}");
//     }
// }


// Console.WriteLine("Input first number: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input second number: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Result(x,y);



//

