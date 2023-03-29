// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.Write("Введите любое целое положительное число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 2;
Console.WriteLine($"Все чётные числа от 1 до {N}:");
while (count <= N)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count ++;
}