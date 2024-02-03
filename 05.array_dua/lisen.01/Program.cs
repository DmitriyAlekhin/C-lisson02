// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить 
// строку с наименьшей суммой элементов.

// // Начальные условия
// int[,] numbers = new int[,] {
//     {1, 2, 3},
//     {1, 1, 0},
//     {7, 8, 2},
//     {9, 10, 11}
// };
// Выводится: 1


Console.WriteLine("Создадим массив 4х3:");
int[,] array = new int[4,3];
RandomArray2d(array);
PrintArray2d(array, "[", "\t", "]\n");

Console.WriteLine(" Просумируем строки двумерного массива получим массив:");
int[] arr = SummMinStrongArray2d(array);
Console.WriteLine("[" + string.Join("\t", arr) + "]");

Console.WriteLine($"Ответ: {minArray(arr)}");



// **************** minArray() ********************************
// * - Возращает минимальное значение масива
// ************************************************************
int minArray(int[] arr){
	int kay = 0;
	for (int i = 0; i < arr.Length; i++) {
		if(arr[kay] > arr[i]){
			kay = i;
		}
	}
	return kay;
}



// **************** SummMinStrongArray2d() ********************
// * - Функция которая суммирует строки двумерного масива
// * и возращает обычный масив
// ************************************************************
int[] SummMinStrongArray2d(int[,] arr){
	int[] arr2 = new int[4];
	for (int i = 0; i < array.GetLength(0); i++){
		int summ = 0;
		for (int j = 0; j < array.GetLength(1); j++) {
			summ += array[i,j];
		}
		arr2[i] = summ;
	}
	return arr2;
}


// **************** RandomArray2d() ***************************
// * - Функция задаёт случайные значения в двумерый масив
// ************************************************************
void RandomArray2d(int[,] array){
	for (int i = 0; i < array.GetLength(0); i++){
		for (int j = 0; j < array.GetLength(1); j++) {
			array[i, j] = new Random().Next(0, 100);
		}
	}
}


// ***************** PrintArray2d() ***************************
// * - (function) красива выводит в кансоль двумерный масив 
// * array 					- Двумерный масив;
// * StartStrong 		- Начало строки
// * interval 			- Интервал между элементами массива
// * FinishStrong		- Конец строки
// ************************************************************
void PrintArray2d(
	int[,] array,
	string StartStrong,
	string interval,
	string FinishStrong)
{
	for (int i = 0; i < array.GetLength(0); i++) {
		Console.Write(StartStrong);
		for (int j = 0; j < array.GetLength(1); j++) {
			if (j == array.GetLength(1) - 1)
				Console.Write(array[i, j] + FinishStrong);
			else
				Console.Write(array[i, j] + interval);
		}

	}

}





// Console.Write(string.Join(",",array[0,1]));