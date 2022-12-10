// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
System.Console.WriteLine("Введите число");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number<100)
{
    System.Console.WriteLine("третьей цифры нет");
}
else
{
    if (Number<1000)
    {
        int result1 = Number%100%10; 
        System.Console.WriteLine(result1);
    }
    else
    {
        if (Number < 10000)
        {
        int result2 = Number%1000%100/10;
        System.Console.WriteLine(result2);
        }
        else
        {
            System.Console.WriteLine("ваше число > 10.000 и этот вариант не проработан");
        }
    }
}
