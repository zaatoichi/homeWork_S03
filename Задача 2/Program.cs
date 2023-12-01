// Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.

Random rnd = new Random();

int size = 10;
int[] arr = new int[size];

for (int i = 0; i < size; i++)
{
    arr[i] = rnd.Next();
}

for (int i = 0; i < size; i++)
{
    System.Console.Write($"{arr[i]} ");
}
  
int n = 0;  

for (int i = 0; i < size; i++)
{
    if (arr[i] % 2 == 0)
    {
        n = n + 1;
    }
    else 
    {
        n = n + 0;
    }
}
System.Console.WriteLine("\nКоличество чётных чисел в массиве: " + n);