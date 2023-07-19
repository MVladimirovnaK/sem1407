//  Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

int size = 8;
Random rnd = new Random();
int[] numbers = new int[size];


for (int i = 0; i < size; i++)
{
    numbers[i] = rnd.Next(0, 2);
    Console.Write($"{numbers[i]} ");
}
Console.WriteLine();
