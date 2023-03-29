// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();
Console.Write("Введите любое целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ещё одно целое число: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numA > numB)
{
    Console.WriteLine($"Число {numA} больше, чем число {numB}");
}
else if (numA < numB)
{
    Console.WriteLine($"Число {numA} меньше, чем число {numB}");
}
else
{
    Console.WriteLine("Числа равны");
}