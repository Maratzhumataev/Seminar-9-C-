// Задача 69. Напишите программу, которая возводит А в целую степень Б.

Console.WriteLine("Введите целое число А");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число B");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PowNumber(numberA, numberB));

int PowNumber (int numA, int numB)
{
    if(numB == 0) return 1;
    return numA * PowNumber(numA, numB -1);
}
