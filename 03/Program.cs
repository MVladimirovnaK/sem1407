// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int product = 1;

for (int i = 1; i < number; i++)
{
    Console.Write($"{i} * ");
    product *= i;
}
Console.Write("\b\b= ");
Console.WriteLine(product);
