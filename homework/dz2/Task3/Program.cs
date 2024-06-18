// Задание №3
// Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
// и показывает наибольшую цифру числа. 

int number = 93;
int firstDigit = number / 10;
int secondDigit = number % 10;
if (number > 9 && number < 100)
    if(firstDigit > secondDigit)
    {
        Console.WriteLine(firstDigit);
    }
    else
    {
        Console.WriteLine(secondDigit);
    }