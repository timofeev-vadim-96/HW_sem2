// Программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
System.Console.WriteLine("Введите число от 1 до 7 для определения того, выходной ли это день недели или нет");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number > 7 & Number < 1)
{
    System.Console.WriteLine("Сказано же - от 1 до 7");
}
else
{
    if (Number == 6|| Number == 7)
    {
        System.Console.WriteLine("Да, это выходной день");
    }
    else
    {
        System.Console.WriteLine("Нет, это будний день");
    }
}
