// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

char[,] string2d = new char [,]{
	{'h','l','l','o','u'},
	{'w','o','r','l','d'}
};

for (int i = 0; i < string2d.GetLength(0); i++){
	for (int j = 0; j < string2d.GetLength(1); j++)
	{
		Console.Write(string2d[i,j]);
	}
	Console.Write(" ");
}