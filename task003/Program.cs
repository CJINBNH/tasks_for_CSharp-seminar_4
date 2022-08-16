// напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int product = 1;
int Cycle(int N)
{
    for (int i = 1; i < N; i++)
    {
        product = product * (i+1);
    }
    return product;
}
if (N == 0) product = 0;
Console.WriteLine($"Произведение от 1 до N равно {Cycle(N)}");