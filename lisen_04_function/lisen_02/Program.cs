// Задача 2: Задайте массив заполненный случайными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в
// массиве.



int[] array = new int[5];
random_number(ref array);

Console.Write($"Случайный массив:[{string.Join(",", array)}] \n");

int caunt_even = caunt_even_erray(array);
Console.WriteLine($"Количество чётнх элементов: {caunt_even}");



int caunt_even_erray(int[] array){
	int caunt = 0;
	foreach (int i in array){
		if(i % 2 == 0){
			caunt++;
		}
	}
	return caunt;
}

void random_number(ref int[] arr){

	for(int i = 0; i < arr.Length; i++){
		arr[i] = new Random().Next(100,1000);
	}
}