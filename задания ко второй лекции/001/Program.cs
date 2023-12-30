
Console.Write($"Введите число: ");
int his_nomber = Convert.ToInt32(Console.ReadLine());

if(his_nomber % 7 == 0 && his_nomber % 23 == 0){
	Console.WriteLine("Это число кратно 7 и 23 одновременно");
}else{
	Console.WriteLine("Это число не кратно 7 или 23");
}
Console.WriteLine("======================================");