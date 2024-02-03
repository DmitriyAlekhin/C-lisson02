// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.


Console.WriteLine($"АТАТА  Является полиномом? Ответ: \t{if_palinom("АТАТА")}");
Console.WriteLine($"АЙАЙАЙ Является полиномом? Ответ:\t{if_palinom("АЙАЙАЙ")}");


bool if_palinom(string my_string){
	bool my_result = true;
	int My_Length = my_string.Length;

	for (int i = 0; i < my_string.Length /2; i++){
		if(my_string[i] != my_string[My_Length - 1]){
			my_result = false;
			break;
		}
		My_Length--;
	}
	return my_result;
}

