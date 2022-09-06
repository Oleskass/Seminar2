//===========================================================
// #12 Напишите программу, которая будет принимать на вход 
// два числа и выводить, является ли второе (первое) число кратным
// первому (второму). Если второе (первое) число некратно первому (второму), то программа 
// выводит о статок от деления.
// Например: 34, 5 -> некратно, остаток 4; 16, 4 -> кратно
//===========================================================

version1(); //if-else
version2(); //ternary operator

void version1() //if-else
{
    Console.WriteLine("Введите первое число (поменьше):");
    string firstNumberLine = Console.ReadLine() ?? "";
    Console.WriteLine("Введите второе число (побольше):");
    string secondNumberLine = Console.ReadLine() ?? "";
    int firstNumber = int.Parse(firstNumberLine);
    int secondNumber = int.Parse(secondNumberLine);

    if (secondNumber % firstNumber == 0)
    {
        Console.WriteLine("Число " + secondNumber + " кратно " + firstNumber);
    }
    else
    {
        Console.WriteLine("Число " + secondNumber + " некратно " + firstNumber + ", остаток " + secondNumber % firstNumber);
    }
}

void version2() //ternary operator
{
    Console.WriteLine("Введите первое число (поменьше):");
    string firstNumberLine = Console.ReadLine() ?? "";
    Console.WriteLine("Введите второе число (побольше):");
    string secondNumberLine = Console.ReadLine() ?? "";
    int firstNumber = int.Parse(firstNumberLine);
    int secondNumber = int.Parse(secondNumberLine);

    Console.WriteLine(secondNumber % firstNumber == 0 ? ("Число " + secondNumber + " кратно " + firstNumber) :
    ("Число " + secondNumber + " некратно " + firstNumber + ", остаток " + secondNumber % firstNumber));
}

//Структурное программировнание
//объявляем глобальные переменные
int firstNumber = 0;
int secondNumber = 0;
bool result = false;

ReadData();
CalculateData();
PrintData();

//получаем два числа от пользователя
void ReadData()
{
    Console.WriteLine("Введите первое число (поменьше):");
    string firstNumberLine = Console.ReadLine() ?? "";
    Console.WriteLine("Введите второе число (побольше):");
    string secondNumberLine = Console.ReadLine() ?? "";
    firstNumber = int.Parse(firstNumberLine);
    secondNumber = int.Parse(secondNumberLine);
}

//определяем кратность чисел
void CalculateData()
{
    result = (secondNumber % firstNumber == 0);
}

//выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Число " + secondNumber + " кратно " + firstNumber);
    }
    else
    {
        Console.WriteLine("Число " + secondNumber + " некратно " + firstNumber + ", остаток " + secondNumber % firstNumber);
    }
}