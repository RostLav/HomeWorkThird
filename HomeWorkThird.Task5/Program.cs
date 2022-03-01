//Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).

Console.WriteLine("Введите диапазон числа А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон числа B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int answer = 0;
int tmp = 0;

if (numberB < numberA)
{
    tmp = numberA;
    numberA = numberB;
    numberB = tmp;
}
    for (int i = numberA; i <= numberB; i++)
    {
        if (i % 7 == 0)
        {
            answer += i;
        }
    }

Console.WriteLine($"Сумма всех чисел, которые делятся на 7 в веденном диапазоне: {answer}");

