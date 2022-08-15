// Задача номер 13
Console.WriteLine("Введите число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > -100 && number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    if (number < 0)
    {
        number = -1 * number;
    }
    string thirdnumber = Convert.ToString(number);
    Console.WriteLine(thirdnumber[2]);
}