Console.Write("Введите число: ");

int.TryParse(Console.ReadLine(), out int number);

string strnumber = Convert.ToString(number);

int lenght = strnumber.Length;

// Console.WriteLine(lenght);

if (lenght >= 3)
{
    Console.WriteLine($"Третья цифра числа {strnumber} - " + strnumber[2]);
}

else
{
    Console.WriteLine("В данном числе отсутсвует третья цифра");
}