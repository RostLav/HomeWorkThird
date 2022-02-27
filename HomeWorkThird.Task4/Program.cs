//Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A.
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int answer = 1;
for (int i = numberA-1; i>=1; i--)
{
    if (numberA % i == 0)
    {
        answer = i;
        break;
    }
}
Console.WriteLine(answer);