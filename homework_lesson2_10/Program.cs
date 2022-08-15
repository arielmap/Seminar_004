// Задача номер 10
Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = -1 * number % 100 / 10;
}
else
{
    number = number % 100 / 10;
}
Console.WriteLine(number);