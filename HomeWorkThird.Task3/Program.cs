// Пользователь вводит 1 число (A). Найдите количество положительных целых чисел, квадрат которых меньше A.
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int answer = 0;
for (int i = 1; i < numberA; i++)
{
    if (i * i < numberA)
    {
        answer += 1;
        Console.WriteLine(i*i);
    }
}
Console.WriteLine($"Количество положительных чисел, квадрат которрых меньше А: {answer}");