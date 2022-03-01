//Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида.
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Второе число");
int numberB = Convert.ToInt32(Console.ReadLine());
int answer = 0;
while(numberA!=0 && numberB!=0)
if (numberA > numberB)
    {
        numberA=numberA - numberB; 
    }
    else
    {
        numberB = numberB - numberA;
    }
answer = numberA+numberB;
Console.WriteLine($"Наибольший общий делитель: {answer}");