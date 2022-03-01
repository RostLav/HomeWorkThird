// Пользователь вводит 1 положительное число (N). Выведите N-ое число ряда фибоначчи.
// В ряду фибоначчи каждое следующее число является суммой двух предыдущих.
// Первое и второе считаются равными 1.

Console.WriteLine("Введите положительное число N");
int numberN = Convert.ToInt32(Console.ReadLine());
int firstNumber = 1;
int secondNumber = 1;
int tmp = 0;
if(numberN <= 2)
{
    Console.WriteLine(1);
}
else
{
    for(int i=2; i<numberN; i++)
    {
        tmp = firstNumber + secondNumber;
        firstNumber = secondNumber;
        secondNumber = tmp;
    }
    Console.WriteLine(tmp);
}
