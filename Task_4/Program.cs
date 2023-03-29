// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.Write("Введите любое целое число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ещё одно целое число: ");
int numB = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ещё одно целое число: ");
int numC = Convert.ToInt32(Console.ReadLine());
int maxNum = numA;

if (numB > maxNum) maxNum = numB;
if (numC > maxNum) maxNum = numC;

Console.WriteLine($"Число {maxNum} наибольшее из трёх");