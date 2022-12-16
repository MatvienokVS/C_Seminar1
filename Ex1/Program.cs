//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

using static System.Console;
Clear();

int a = Convert.ToInt32(ReadLine());
int b = Convert.ToInt32(ReadLine());

if (a > b)
{
	WriteLine($"Большее число {a}");
}
else
{
	WriteLine($"Большее число {b}");
}