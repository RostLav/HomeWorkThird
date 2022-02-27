//Пользователь вводит 2 числа (A и B). Возвести число A в степень B.
Console.WriteLine("Введите число А:");
double numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число В:");
double numberB = Convert.ToInt32(Console.ReadLine());
double answer = 1;
for(int i = 0; (i<numberB&&numberB>0)||(i>numberB&&numberB<0);)
    if(numberB<0){
        answer /= numberA;
        i--;
    }
    else
    {
        answer *= numberA;
        i++;
    }
Console.Write(answer);