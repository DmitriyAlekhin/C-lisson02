// double ColculetFormul(int a, int b, int c, int d)
// {
// 	return (double)(a * b) / (c + d);
// }

// Console.WriteLine(ColculetFormul(1, 2, 3, 4));

void ZeroEventElement(int[] arr)
{
	for (int i = 0; i < arr.Length; i++)
	{
		if (arr[i] % 2 == 0)
		{
			arr[i] = 0;
		}
	}
}

void PrintArray(int[] arr)
{
	foreach (int e in arr){
		Console.Write($"{e} ");
	}
}

int[] array = { 1, 2, 3, 4, 5};
ZeroEventElement(array);
PrintArray(array);
