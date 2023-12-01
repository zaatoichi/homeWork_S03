// Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.

Random rnd = new Random();

int size = 10;
double[] arr = new double[size];

for (int i = 0; i < size; i++)
{
    arr[i] = Math.Round(rnd.Next(10) + rnd.NextDouble(), 2);
}

for (int i = 0; i < size; i++)
{
    System.Console.Write($"{arr[i]} \t");
}

double max = 0;
for (int i = 0; i < size; i++)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
}

double min = arr[0];
for (int i = 0; i < size; i++)
{
    if (arr[i] < min)
    {
        min = arr[i];
    }
}

double res = max - min

System.Console.WriteLine("\n\nМаксимальный элемент массива: " + max);
System.Console.WriteLine("\nМинимальный элемент массива: " + min);
System.Console.WriteLine("\nРазница между максимальным и минимальным элементами: " + );