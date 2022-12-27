// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным

int number = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(number);
if (number > 0 && number < 8)
{
    if (number == 7 || number == 6)
    {
        Console.Write("Выходной");
    }
    else
    {
        Console.Write("Рабочий");
    }
}
else
{
    Console.Write("Невозможно определить день недели");
}
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}