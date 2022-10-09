// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
Console.Clear();
int InputMNumbers()
{
    Console.Write("Введите количество раз ввода чисел с клавиатуры: ");
    int mNumbers = 0;
    while (!int.TryParse(Console.ReadLine(), out mNumbers) || mNumbers < 0)
    {
        Console.Write("Введите количество раз ввода чисел с клавиатуры: ");
    }
    return mNumbers;
}
void Logic(int mNumbers, int[] n, int count)
{
    for (int i = 0; i < mNumbers; i++)
    {
        Console.Write($"Введите число под индексом {i}: ");
        n[i] = Convert.ToInt32(Console.ReadLine());
        if (n[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количество чисел больше нуля = {count}");
}
int mNumbers = InputMNumbers();
int[] n = new int[mNumbers];
int count = 0;
Logic(mNumbers, n, count);


