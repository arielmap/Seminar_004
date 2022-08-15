Console.WriteLine("Введите цифру, обозначающую день недели ");
Console.WriteLine("1 - Понедельник, 2 - Вторник, 3 - Среда, 4 - Чтетверг, 5 - Пятница, 6 - Суббота, 7 - Воскресенье");
int number1 = Convert.ToInt32(Console.ReadLine());
if (number1 == 6 || number1 == 7)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}