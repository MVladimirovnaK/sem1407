// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

for (int i = number; i > 0; i /= 10)
    count ++;
Console.WriteLine(count);