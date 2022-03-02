// Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.
Console.WriteLine("Введите число ");
int numberN=Convert.ToInt32(Console.ReadLine());
int answer = 0;

while (numberN != 0)
{
    if ((numberN%10) % 2 == 1)
    {
        answer++;
    }
    numberN/=10;
}
Console.WriteLine($"Количество нечетных цифр цисла: {answer}");