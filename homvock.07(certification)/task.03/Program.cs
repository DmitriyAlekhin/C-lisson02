// Задача 3: Задайте произвольный массив.
//  Выведете его элементы, начиная с конца.
//  Использовать рекурсию, не использовать циклы.


int [] array = new int [10]{0,3,9,1,1,2,3,7,6,10};

Console.WriteLine($"Начальный мосив:\t[{string.Join(" ", array)}]");
Console.Write("Конечный мосив: \t[");
print_array_revers(array);
Console.Write("]");



void print_array_revers(int[] array, int i = 0){
	if(i > array.Length - 1){
		return;
	}
	print_array_revers(array, i + 1);

	// Код ниже просто улучшает вывод. Достаточно будет :
	// Console.Write($"{array[i]} ");
	if(i == 0)
		Console.Write($"{array[i]}");
	else
		Console.Write($"{array[i]} ");
	
}

