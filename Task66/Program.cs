// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());
int sum = 0;
if (numberM == numberN)
    {
        Console.WriteLine("Числа M и N равны");
    }
else
{
    SumFromMtoN (numberM, numberN);
}

void SumFromMtoN (int numM, int numN)
{
    if (numM == numN) 
    {
        sum += numM;
        Console.WriteLine($"Сумма чисел равна {sum}");
        return;
    }
    else
    if (numM < numN)
    {
        sum += numM;
        SumFromMtoN (numM+1, numN);
    }
    else
    if (numM > numN)
    {
        sum += numN;
        SumFromMtoN (numM, numN+1);
    }
    }