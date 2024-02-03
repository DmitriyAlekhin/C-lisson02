// Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет:

//  "Позиция по рядам выходит за пределы массива"
// или "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы.

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// };

// int x = 2;
// int y = 2;

// Выводится: 6

int[,] array = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
};

int x = 0; // Число строк
int y = 3; // Число столбцов

// Console.WriteLine(array.GetLength(0));
// Console.WriteLine(array.GetLength(1));





// ************************ isRange() *************************
// * - Проверяет находится ли элемент в деапозоне
// ************************************************************
bool isRange(int[,] array, int x, int y){
	if( x < 0 || x > array.GetLength(0) - 1 ){
		return false;
	} else if(y < 0 || y > array.GetLength(1) - 1){
		return false;
	} else {
		return true;
	}
}

Console.WriteLine(isRange(array, x, y));



finfIsArray(int[,] array, int x, int y){
	return array[x,y];
}