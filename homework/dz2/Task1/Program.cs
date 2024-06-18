// Задача 1:
// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно ддновременно 7 и 23

Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());

if(a % 7 == 0 && a % 23 == 0)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}


