// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.



string random_is_string = random_string(40);
Console.WriteLine($"Сгенирированная строка: \t {random_is_string}");

Console.WriteLine($"Строка уменшиная в размерах: \t {min_register(random_is_string)}");



string min_register(string is_string){
	string min_gigister = "";

	string max_string = "AEIOUYBCDFGHJKLMNPQRSTVWXZ";
	string min_string = "aeiouybcdfghjklmnpqrstvwxz";

	for (int i = 0; i < is_string.Length; i++){
		char is_char = is_string[i];

		for (int j = 0; j < max_string.Length; j++) {
			if(max_string[j] == is_string[i]) {
				is_char = min_string[j];
				break;
			}
		}
		min_gigister = min_gigister + is_char;
	}
	return min_gigister;
}




string random_string(int length, string abs = "AEIOUYBCDFGHJKLMNPQRSTVWXZaeiouybcdfghjklmnpqrstvwxz"){
	string is_string = "";
	for (int i = 0; i < length; i++){
		int number = new Random().Next(0,abs.Length);
		is_string = is_string + abs[number];
	}
	return is_string;
}
