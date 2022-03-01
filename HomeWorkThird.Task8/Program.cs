// Пользователь вводит целое положительное число, которое является кубом целого числа N.
// Найдите число N методом половинного деления.
Console.WriteLine("Введите число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
int leftBorder = 0;
int rightBorder = numberN;
int halfNumber = 0;
while(leftBorder*leftBorder*leftBorder != numberN && rightBorder*rightBorder*rightBorder != numberN)
{
    halfNumber = (leftBorder + rightBorder) / 2;
    if (halfNumber * halfNumber * halfNumber > numberN)
    {
        rightBorder = halfNumber;
    }
    else
    {
        leftBorder = halfNumber;
    }
}
Console.WriteLine(halfNumber);