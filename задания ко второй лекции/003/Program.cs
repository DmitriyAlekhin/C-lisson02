// Задача 3: Напишите программу, которая принимает
// на вход целое число из отрезка [10, 99] и показывает
// наибольшую цифру числа.

Console.WriteLine("Введите число из деапозона [10, 99]");
Console.Write("Ваше число: ");
int his_number = Convert.ToInt32(Console.ReadLine());
int i1 = his_number / 10;
int i2 = his_number % 10;
int max = 0;

Console.WriteLine($"Первое число: {i1}");
Console.WriteLine($"Второе число {i2}");

if(i1 >= i2) max = i1;
if(i2 >= i1) max = i2;

Console.WriteLine($"----------------------------------------- \n Большим числом является: {max} \n ========================================");