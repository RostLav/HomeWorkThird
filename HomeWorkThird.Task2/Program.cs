//Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A.
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
for(int i = numberA; i<=1000; i += numberA)
{
    Console.WriteLine($"Все числа от 1 до 1000, которые делятся на A: {i}");
}
