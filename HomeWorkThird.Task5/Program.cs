//Пользователь вводит 2 числа (A и B). Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7. (Учтите, что при вводе B может оказаться меньше A).

//Console.WriteLine("Введите число А: ");
int numberA = 30;//Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число B: ");
int numberB = 10;//Convert.ToInt32(Console.ReadLine());
int answer = 0;
if (numberA < numberB)
{
    for (int i = numberA; i <= numberB; i++)
    {
        if (i % 7 == 0)
        {
            answer += i;
        }
    }
}
else
{
    for (int j = numberB; j <= numberA; j++)
    {
        if(j % 7 == 0)
        {
            answer += j;
        }
    }
}

Console.WriteLine(answer);

