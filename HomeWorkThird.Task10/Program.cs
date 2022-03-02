//Пользователь вводит 1 число. Найти число, которое является
//зеркальным отображением последовательности цифр заданного числа, например, задано число 123, вывести 321.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
int mirrorNumbers = 0;
int tmp;
while (number != 0)
{
    tmp = number % 10;
    mirrorNumbers = mirrorNumbers * 10 + tmp;
    number /= 10;
}
Console.WriteLine(mirrorNumbers);