Console.Write("Введите цифру, обозначающую день недели ");

int.TryParse(Console.ReadLine(), out int DayNumber);

if (DayNumber == 6 || DayNumber == 7)
{
    Console.WriteLine("Этот день выходной");
}

else if (DayNumber < 1 || DayNumber > 7)
{
    Console.WriteLine("Вы ввели число, которое не соответсвует дню недели");
}
else Console.WriteLine("Этот день не выходной");
