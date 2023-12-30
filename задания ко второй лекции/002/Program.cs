// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой
//  находится эта точка.

Console.Write("Введите кординату X: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кординату Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if(X == 0 || Y == 0){
	Console.WriteLine("Кодинаты X и Y не могут быть равны (0)");
}else{
	Console.Write("№ кординатной плоскасти: ");
	if( X > 0 && Y > 0) Console.WriteLine(1);
	if( X < 0 && Y > 0) Console.WriteLine(2);
	if( X > 0 && Y < 0) Console.WriteLine(4);
	if( X < 0 && Y < 0) Console.WriteLine(3);
}
Console.WriteLine("=============================");