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

// С помощью библиотеки
int sqr1 = Convert.ToInt32(Math.Pow(number,2));
Console.WriteLine("Вывод с помощью библиотеки: ");
Console.WriteLine($"Квадрат числа {number}  равен = {sqr1}");