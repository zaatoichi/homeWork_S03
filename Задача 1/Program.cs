// Задача 1: Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

using System.Globalization;

Random rnd = new Random();

int size = 10;
int[] arr = new int[size];
int i = 0;

while (i < size)
{
    arr[i] = rnd.Next(1, 101);
    i = i + 1;
}

i = 0;
while (i < size)
{
    System.Console.Write($"{arr[i]} ");
    i = i + 1;
}
  
int n = 0; 
for (int j = 0; j < size; j++)
{
    if (arr[j] > 20 && arr[j] < 90)
    {
n = n + 1;
    }
    else {
        n = n + 0;
    }
}
System.Console.WriteLine("\nКол-во элементов массива, лежащих в промежутке от 20 до 90: " + n);