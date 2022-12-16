//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using static System.Console;
Clear();

int n = Convert.ToInt32(ReadLine()!);

int result = Convert.ToInt32(1);

while (result <= n)
{
	if (result % 2 == 0)
	{
		Write($"{result} ");
		result += 2;
	}
	else
	{
		result += 1;
	}
}
