/*// Напишите программу, которая на вход принимет 2 числа и выдает какое число большее, а какое меньшее
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
*/
/*// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
Console.Write("Введите число 1: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число 2: ");
int numberB = int.Parse(Console.ReadLine());
Console.Write("Введите число 3: ");
int numberC = int.Parse(Console.ReadLine());
 if((numberA == numberB) & (numberB == numberC) & (numberC == numberA))
 {
  Console.WriteLine("Ваши числа равны");  
 }
 else
 {
    double max = numberA;
    if(max < numberB) max = numberB;
    if(max < numberC) max = numberC;
    Console.WriteLine("Максимальное число из этих чисел:" +max);
 }
 */

 /*Напишите программу, которая на вход принимает число и выдаёт является ли число четным
  (делится ли оно на два без остатка)
  Console.Write("введите число : ");
  int numberF = int.Parse(Console.ReadLine());
  double rem = numberF % 2;
  if (rem == 0)
  {
   Console.WriteLine("Ваше число чётное"); 
  }
  else
  {
     Console.WriteLine("Ваше число нечётное"); 
  }
  */

  /* Напишите программу, которая на вход принимает число (N), 
  а на выходе показывает все четные числа от 1 до (N)*/
  Console.Write("Введите число : ");
  int num = int.Parse(Console.ReadLine());
  double current;
  if(num >= 1)
  {
    current = 1;
    while(current <= num)
    {
        double rem = current % 2;
        if(rem == 0) Console.Write(current + " ");
        current ++;
    }
  }
  if(num <= 1)
  {
    current = -1;
    while(current >= num)
  {
    double rem = current % 2;
    if(rem == 0) Console.Write(current + " ");
        current ++;
        current --;
  }
  }

