// напишите программу, которая принимает на вход число и выдает количество цифр в числе

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string toString = number.ToString();
// int numberLength = toString.Length;
// Console.WriteLine(numberLength);

//второй вариант

Console.Clear();
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int Cycle(int number)
{
    int count = 0;
    while (number > 0)
    {
        number = number / 10;
        count += 1;
    }
    return count;
}
Console.WriteLine($"В числе {Cycle(number)} цифр");