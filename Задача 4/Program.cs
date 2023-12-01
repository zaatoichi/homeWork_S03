// Задача 4**(не обязательно): Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. 
// Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

System.Console.WriteLine("Введите число в диапазоне от 1 до 100000: ");
string text_num = Console.ReadLine();
int num = Convert.ToInt32(text_num);

int size = text_num.Length;

int[] arr = new int[size];


for (int i = 1; i < size + 1; i++)
{
    arr[size - i] = num % 10;
    num /= 10;
}
 
for (int i = 0; i < size; i++)
{
    System.Console.Write($"{arr[i]} \t");
}