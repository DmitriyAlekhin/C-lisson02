// Задача 4: Напишите программу, которая на вход
// принимает натуральное число N, а на выходе
// показывает его цифры через запятую.

// 568 => 5,6,8
// 8 => 8
// 9542 => 9,5,4,2

Console.Write("Натуральное целочисленое число \n Ввидите :");
int his_nomber = Convert.ToInt32(Console.ReadLine());
string good = "";

Console.WriteLine("-----------------------------");
while(his_nomber > 0){
	if(his_nomber>10){ 	good = good + his_nomber%10 + ",";}
	else { good = good + his_nomber%10;	}
	his_nomber = his_nomber/10;
}
Console.WriteLine($"Ваше число: {good}");
Console.WriteLine("=============================");

