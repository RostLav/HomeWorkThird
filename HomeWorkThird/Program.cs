//Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
Console.WriteLine("Введите число А:");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В:");
int numberB = Convert.ToInt32(Console.ReadLine());
double answer = 1;

if (numberB < 0)
{
    numberA = 1 / numberA;
    numberB = -numberB;
}
for(int i =0; i<numberB; i++)
{
    answer *= numberA;
}
Console.Write($"А в степени В = {answer}");