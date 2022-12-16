//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using static System.Console;
Clear();

int a = Convert.ToInt32(ReadLine()!);
int b = Convert.ToInt32(ReadLine()!);
int c = Convert.ToInt32(ReadLine()!);

int max = a;

if (max < b)
{
	max = b;
	if (max < c)
	{
		max = c;
	}
}
else
{
	if (max < c)
	{
		max = c;
	}
}
WriteLine($"Максимальное число {max}");
