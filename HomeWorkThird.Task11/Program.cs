//Пользователь вводит целое положительное  число (N).
//Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных.  

//Console.WriteLine("Введите число N:");
int numberN = 60;//Convert.ToInt32(Console.ReadLine());

for (int i = 1; i < numberN; i++)
{
    int copyI=i;
    int evenNumber = 0;
    int oddNumber = 0;   
    while (copyI != 0)
    {
        if ((copyI % 10) % 2 == 1)
        {
            oddNumber += copyI%10;
        }
        else if ((copyI % 10) % 2 == 0)
        {
            evenNumber += copyI%10;
        }
        copyI = copyI/10;
    }
    if (evenNumber > oddNumber)
    {
        Console.WriteLine(i);
    }
}



