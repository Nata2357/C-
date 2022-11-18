int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(RabVyj(dayNumber));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string RabVyj(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Это " + a + " - Выходной");
        }
        else
        {
            Console.Write("А это " + a + " - Рабочий (не ленись!)");
        }
    }
    else
    {
        Console.Write("Вы ввели число не в пределе от 1 до 7");
    }
    return " день.";
}
