// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = DigitsSum (number);
Console.WriteLine(sum);

int DigitsSum(int n)
 {
    if (n == 0) return 0;
    return n % 10 + DigitsSum(n/10);
}