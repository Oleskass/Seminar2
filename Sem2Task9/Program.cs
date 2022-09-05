//===========================================================
// #9 Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например: 78 -> 8, 12-> 2, 85 -> 8
//===========================================================

System.Random numberGenerator = new System.Random();
int number = numberGenerator.Next(9, 100);
//int number = new Random().Next (9,100); //это то же самое, но в одну строку

Console.WriteLine(number);

int firstDigit = number / 10;
int secondDigit = number % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}