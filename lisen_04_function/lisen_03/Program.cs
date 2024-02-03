// Задача 3: Напишите программу, которая перевернёт
// одномерный массив (первый элемент станет
// последним, второй – предпоследним и т.д.)

int[] array = new int[5];

random_number(ref array);
Console.WriteLine($"Исходный масив: [{string.Join(",",array)}]");

revers_array(ref array);
Console.WriteLine($"Переввёрнутый масив: [{string.Join(",",array)}]");

void revers_array(ref int[] arr){
	int[] revers_array = new int[arr.Length];
	for(int i = 0; i < arr.Length; i++){
		revers_array[i] = arr[arr.Length - i - 1];
	}
	arr = revers_array;
	
}

void random_number(ref int[] arr){
	for(int i = 0; i < arr.Length; i++){
		arr[i] = new Random().Next(1,100);
	}
}

