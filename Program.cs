// Программа, которая принимет на вход трехзначное число и на выходе показывает вторую цифру этого числа.
System.Console.WriteLine("Введите трехзначное число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
int intermediateValue = firstNumber%100;
int result = intermediateValue/10;
System.Console.WriteLine("Второе число это " + result);