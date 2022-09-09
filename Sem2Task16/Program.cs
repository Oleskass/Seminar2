//===========================================================
// #12 Напишите программу, которая принимает на вход два числа 
// и проверяет, является ли одно число квадратом другого.
// Например: 5, 25 -> да, -4, 16 -> да, 25, 5 -> да 8,9 -> нет
//===========================================================

//Структурное программировнание

//чтение данных пользователя
int ReadData(string line)
{
    //выводим сообщение
    Console.WriteLine(line);
    //считываем число
    int number = int.Parse(Console.ReadLine() ?? "0");
    //возвращаем значение
    return number;
}

//тест на квадрат
bool SqrTest(int firstNum, int secondNum)
{
    if (secondNum == firstNum * firstNum)
    {
        return true;
    }
    else
    {
        return false;
    }
}

//вывод данных
void PrintData(int firstNum, int secondNum)
{
    if (SqrTest(firstNum, secondNum))
    {
        Console.WriteLine("Число " + secondNum + " квадрат числа " + firstNum);
    }
    else
    {
        Console.WriteLine("Число " + secondNum + " не квадрат числа " + firstNum);
    }
}

int num1 = ReadData("Введите число 1:");
int num2 = ReadData("Введите число 2:");

PrintData(num1, num2);
PrintData(num2, num1);