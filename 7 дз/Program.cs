// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
int number1 = new int();
System.Console.WriteLine("Введите первое число ");
number1 = Convert.ToInt32(Console.ReadLine());
int number2 = new int();
System.Console.WriteLine("Введите второе число ");
number2 = Convert.ToInt32(Console.ReadLine());
int max = number1;
int min = number2;
if (min > number1) min = number1;
if (max < number2) max = number2;
System.Console.WriteLine("Большее число =");
Console.WriteLine(max);
System.Console.WriteLine("Меньшее число =");
Console.WriteLine(min);