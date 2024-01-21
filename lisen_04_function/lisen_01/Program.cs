// Задача 1: Напишите программу, которая бесконечно
// запрашивает целые числа с консоли. Программа
// завершается при вводе символа ‘q’ или при вводе
// числа, сумма цифр которого четная.


int caunt = 1;
int[] array = new int[caunt];

while(true){
	Console.Write($"Введите [{caunt - 1}] элемент масива: ");
	string read = Console.ReadLine()!;
	if(read == "q" || int.Parse(read) % 2 == 0 && int.Parse(read)/10 != 0)	{
		Array.Resize(ref array,caunt - 1);
		break;
	}
	array[caunt - 1] = int.Parse(read);
	caunt++;
	Array.Resize(ref array,caunt);
}


Console.Write(string.Join(",", array));












// void puch(ref int[] arr, int n){  // Array.Resize(ref array,10); --> ???
// 	int[] new_array = new int[n];
// 	for(int i = 0; i < new_array.Length; i++){
// 		new_array[i] = arr[i];
// 	}
// 	arr = new_array;
// }
// puch(ref array, 10);

// Array.Resize(ref array,10);

