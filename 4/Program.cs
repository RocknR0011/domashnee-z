int number1 = new int();
System.Console.WriteLine("Введите число 1 : ");
number1 = Convert.ToInt32(Console.ReadLine());
int number2 = new int();
System.Console.WriteLine("Введите число 2 : ");
number2 = Convert.ToInt32(Console.ReadLine());

if (number2 / number1 == number1)
{ Console.WriteLine("да"); }

if (number2 / number1 < number1)
{ Console.WriteLine("нет"); }

if (number2 / number1 > number1)
{ Console.WriteLine("нет"); }
