// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую 
// и последнюю строку массива.

// Начальные условия:

// int[,] numbers = new int[,] {
//     {1, 2, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 
// Выводится:

// 9   10  11  12
// 5   6   7   8
// 1   2   3   4

// int[,] array2d = new int[,] {
//     {1, 4, 3, 4},
//     {5, 6, 7, 8},
//     {9, 10, 11, 12}
// }; 


// PrintArray2d(array2d);
// revers_row_is_array2d(ref array2d, 0, array2d.GetLength(0)- 1);
// Console.WriteLine("");
// PrintArray2d(array2d);




// int[] row_is_array2d(int[,] array2d, int nambers_string){
// 	int [] row= new int[array2d.GetLength(1)];
// 	for (int i = 0; i < array2d.GetLength(1); i++) {
// 		row[i] = array2d[nambers_string,i];
// 	}
// 	return row;
// }




// void revers_row_is_array2d(ref int[,] array2d, int number_row1, int number_row2){
// 	int[] row_is_array2d_up = row_is_array2d(array2d,number_row1);
// 	int[] row_is_array2d_daun = row_is_array2d(array2d,number_row2);

// 	for (int i = 0; i < array2d.GetLength(1); i++) {
// 		array2d[number_row1,i] = row_is_array2d_daun[i];
// 	}
// 	for (int i = 0; i < array2d.GetLength(1); i++) {
// 		array2d[number_row2,i] = row_is_array2d_up[i];
// 	}
// }



// void PrintArray2d(int[,] array)
// {
// 	for (int i = 0; i < array.GetLength(0); i++) {
// 		// Console.Write(StartStrong);
// 		for (int j = 0; j < array.GetLength(1); j++) {
// 			if (j == array.GetLength(1) - 1)
// 				Console.Write(array[i, j] + "\n");
// 			else
// 				Console.Write(array[i, j] + "\t");
// 		}

// 	}

// }


 int[,] array = new int[,] {
    {1, 2, 3, 4},
    {5, 6, 7, 8},
    {9, 10, 11, 12}
}; 
PrintArray2d(array);

array = SwapFirstLastRows(array);

PrintArray2d(array);



int[,] SwapFirstLastRows(int[,] array) {
	for(int i = 0; i < array.GetLength(1); i++) {
	int tmp = array[2, i];
		array[2, i] = array[0, i];
	array[0, i] = tmp;
	}
	return array;
}

void PrintArray2d(int[,] array)
{
	for (int i = 0; i < array.GetLength(0); i++) {
		// Console.Write(StartStrong);
		for (int j = 0; j < array.GetLength(1); j++) {
			if (j == array.GetLength(1) - 1)
				Console.Write(array[i, j] + "\n");
			else
				Console.Write(array[i, j] + "\t");
		}

	}

}