/* Напишите программу,
которая на вход принимает число
и выдаёт его квадрат
*/

Console.Write("Введите число");
int number = int.Parse( Console.ReadLine());

// Математически 
int sqr = number * number;
Console.WriteLine("Вывод математическим методом: ");
Console.WriteLine($"Квадрат числа {number} равен = {sqr}");
