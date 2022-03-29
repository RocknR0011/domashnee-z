//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
int number1 = new int();
System.Console.WriteLine("Введите число от 1 до 7 : ");
number1 = Convert.ToInt32(Console.ReadLine());
if (number1 == 1)
{ Console.WriteLine("понедельник"); }
if (number1 == 2)
{ Console.WriteLine("вторник"); }
if (number1 == 3)
{ Console.WriteLine("среда"); }
if (number1 == 4)
{ Console.WriteLine("четверг"); }
if (number1 == 5)
{ Console.WriteLine("пятница"); }
if (number1 ==6)
{ Console.WriteLine("суббота-выходной"); }
if (number1 == 7)
{ Console.WriteLine("воскресенье-выходной"); }

