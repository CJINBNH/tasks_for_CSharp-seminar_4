// напишите программу, которая принимает на вход числа А и выдает сумму чисел от 1 до А

// Console.Write("Введите число: ");
// int A = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= A; i++)
// {
//     sum = sum + i;
// }


//решение с помощью функции

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
int cycle(int a)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum = sum + i;
    }
    return sum;
}
int sum = cycle(A);

Console.WriteLine($"Сумма чисел от 1 до А: {sum}");