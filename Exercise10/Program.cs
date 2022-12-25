//Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int number = ReadInt("Введите трехзначное число: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    int result = ((number / 10) % 10);
    Console.WriteLine(result);
}
// Функция ввода сообщения
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}