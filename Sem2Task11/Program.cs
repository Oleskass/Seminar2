//===========================================================
// #11 Напишите программу, которая выводит случайное 
// трёхзначное число и удаляет вторую цифру этого числа.
// Например: 456 -> 46, 782 -> 72, 918 -> 98
//===========================================================

version1(); //first and third digits
version2(); //char

void version1() //first and third digits
{
    int number = new Random().Next (99,1000);
    Console.WriteLine(number);
    int firstDigit = number / 100;
    int thirdDigit = number % 10;
    Console.WriteLine(firstDigit + "" + thirdDigit);
    //Console.WriteLine(firstDigit*10 + thirdDigit); //ещё один вариант вывода
}

void version2() //char
{
    int number = new Random().Next (99,1000);
    Console.WriteLine(number);
    char[] charArray = number.ToString().ToCharArray();
    Console.WriteLine(charArray[0] + "" + charArray[2]);
    //Console.Write(charArray[0]); //ещё один вариант вывода
    //Console.WriteLine(charArray[2]);
}