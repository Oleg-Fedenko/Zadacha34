/*Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.WriteLine("Введите длину массива:  ");
int size = int.Parse(Console.ReadLine()!);
int[] num = new int[size];
RandomNumbers(num);
Console.WriteLine("В этом массиве: ");
PrintArray(num);

void RandomNumbers(int[] num)
{
    for(int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}


int count = 0;

for (int j = 0; j < num.Length; j++)
{
if (num[j] % 2 == 0)
count++;
}
Console.WriteLine($"из {num.Length} чисел, {count} четных");


void PrintArray(int[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}