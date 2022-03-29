//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
int number = new int();
System.Console.WriteLine("Введите 3ех значное число ");
number = Convert.ToInt32(Console.ReadLine());
number = number / 10 ;
int number1 = number % 10;
Console.WriteLine(number1);