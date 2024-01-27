// Вопрос почемму если перенести функцию puch() в [1] возникает ошибка.
// eeror: Невозможно использовать локальную переменную "array" перед ее объявлением

void  Rundom_Number(int[] arr) {
	int i = 0;
	while(i <= arr.Length - 1){
		arr[i] = new Random().Next(1,100);
		i++;
	}
}

// ссылка -> [1] место для переноса функции


int[] array = new int[1];
Console.WriteLine($"Начальный масив: \t\t\t [{string.Join(",", array)}]");

Rundom_Number(array);
Console.WriteLine($"Начальный масив стал ранномным: \t [{string.Join(",", array)}]");

puch(ref array, 10);
Console.WriteLine($"Новый масив: \t\t\t\t [{string.Join(",", array)}]");




int caunt = 1;
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

Console.WriteLine($"Введённый массив: \t\t\t [{string.Join(",", array)}]");



// фкнкция push() Перенесите её в место для вставки 
void puch(ref int[] arr, int n)
{
	int[] new_array = new int[n];
	for (int i = 0; i < array.Length; i++){
		new_array[i] = array[i];
	}
	array = new_array;
}




























// int caunt = 1;
// int[] array = new int[caunt];

// while(true){
// 	Console.Write($"Введите [{caunt - 1}] элемент масива: ");
// 	string read = Console.ReadLine()!;
// 	if(read == "q" || int.Parse(read) % 2 == 0 && int.Parse(read)/10 != 0)	{
// 		puch(ref array,caunt - 1);
// 		break;
// 	}
// 	array[caunt - 1] = int.Parse(read);
// 	caunt++;
// 	puch(ref array,caunt);
// }


// // Console.Write(string.Join(",", array));


// void puch(ref int[] arr, int n){  // Array.Resize(ref array,10); --> ???
// 	int[] new_array = new int[n];
// 	for(int i = 0; i < new_array.Length; i++){
// 		new_array[i] = arr[i];
// 	}
// 	arr = new_array;
// }
// puch(ref array, 10);

// // Array.Resize(ref array,10);


