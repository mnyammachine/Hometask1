// Программа принимает трехзначное число, на выходе показывает вторую цифру этого числа 
int n = new Random().Next (100, 1000);
Console.WriteLine ("Number = " + n);
int digit = n / 10 % 10;
Console.WriteLine("Искомое число = " + digit);// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
