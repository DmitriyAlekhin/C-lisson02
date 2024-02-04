// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.


int M,N;

M = 1;
M++;
N = 10;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($" Начало диопозона: {M} \n Конец Диапозона: {N}");
Console.ResetColor();
	
my_while(M,N);

void my_while(int M, int N){
	if(M == N){
		return;
	}
	Console.Write($" {M}");
	
	my_while(M + 1,N);
}
