//===========================================================
// #10 Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру 
// этого числа. Например: 456 -> 5, 782 -> 8, 918 -> 1
//===========================================================

//через  char
ReadData2();
CalculateData2();
PrintData2();

//объявляем глобальные переменные
string inputLine;
char[] charArray;

//получаем число от пользователя
void ReadData2()
{
    Console.WriteLine("Введите число от 100 до 999: ");
    inputLine = Console.ReadLine()??"";
}

//вычисления
void CalculateData2()
{
    charArray = inputLine.ToCharArray();
}

//вывод результата
void PrintData2()
{
    if (inputLine.Length == 3)
    {
        Console.WriteLine("Вторая цифра введённого вами числа: " + charArray[1]);
    }
    else
    {
        Console.WriteLine("Это не трёхзначное положительное число, попробуйте снова :ъ");
    }
}



////Вариант решения 1
// ReadData();
// CalculateData();
// PrintData();

// //объявляем глобальные переменные
// int inputNumber, secondDigit;

// //получаем число от пользователя
// void ReadData()
// {
//     Console.WriteLine("Введите число от 100 до 999: ");
//     string inputLine = Console.ReadLine() ?? "";
//     inputNumber = int.Parse(inputLine);
// }

// //вычисление второй цифры в числе
// void CalculateData()
// {
//     secondDigit = (inputNumber / 10 % 10);
// }

// //вывод результата
// void PrintData()
// {
//     if (inputNumber > 99 && inputNumber < 1000)
//     {
//         Console.WriteLine("Вторая цифра введённого вами числа: " + secondDigit);
//     }
//     else
//     {
//         Console.WriteLine("Это не трёхзначное положительное число, попробуйте снова :ъ");
//     }
// }
