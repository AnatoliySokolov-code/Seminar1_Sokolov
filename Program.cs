// Напишите задачу, которая на вход принимет 2 числа и выдает какое число большее, а какое меньшее
Console.Write("введите число 1: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("введите число 2: ");
int number2 = int.Parse(Console.ReadLine());
if (number1 > number2)
{
Console.WriteLine($"{number1} - большее число, {number2} - меньшее число");
}
if (number1 < number2)
{
Console.WriteLine($"{number2} - большее число, {number1} - меньшее число");
}
