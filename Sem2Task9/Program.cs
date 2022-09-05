//===========================================================
// #9 Напишите программу, которая выводит случайное число 
// из отрезка [10, 99] и показывает наибольшую цифру числа.
// Например: 78 -> 8, 12-> 2, 85 -> 8
//===========================================================

version1(); //if-else
version2(); //ternary operator
version3(); //char

void version1() //if-else
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(9, 100);
    //int number = new Random().Next (9,100); //это то же самое, но в одну строку
    Console.WriteLine("Метод 1:\n" + number);
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
}
void version2() //ternary operator
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(9, 100);
    Console.WriteLine("Метод 2:\n" + number);
    int firstDigit = number / 10;
    int secondDigit = number % 10;

    Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);
}
void version3() //char
{
    System.Random numberGenerator = new System.Random();
    int number = numberGenerator.Next(9, 100);
    Console.WriteLine("Метод 3:\n" + number);
    int firstDigit = number / 10;
    int secondDigit = number % 10;
    char[] charArray = number.ToString().ToCharArray();

    Console.WriteLine((int)charArray[0] > (int)charArray[1] ? charArray[0] : charArray[1]);
}