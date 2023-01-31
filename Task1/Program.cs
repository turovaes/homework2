Console.Write("Введите трёхзначное число: ");

int.TryParse(Console.ReadLine(), out int number);

string strnumber = Convert.ToString(number);

int lenght = strnumber.Length;

// Console.WriteLine(lenght);

if (lenght == 3)
{
    Console.WriteLine($"Вторая цифра числа {strnumber} - " + strnumber[1]);
}

else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}

