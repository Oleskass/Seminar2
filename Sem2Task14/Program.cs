//===========================================================
// #14 Напишите программу, которая принимает на вход число 
// и проверяет, кратно ли оно одновременно 7 и 23.
// Например: 14 -> нет, 46 -> нет, 161 -> да
//===========================================================

ReadData();
CalculateData();
PrintData();

//объявляем глобальные переменные
int inputNumber; //в значениях будет 0 по умолчанию
bool result;

//получаем число от пользователя
void ReadData()
{
   Console.WriteLine("Введите число:");
    string inputLine = Console.ReadLine() ?? "";
    inputNumber = int.Parse(inputLine);

}

//определяем кратность чисел
void CalculateData()
{
    result = (inputNumber % 7 == 0 && inputNumber % 23 == 0);
}

//выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine(inputNumber + " одновременно кратно 7 и 23");
    }
    else
    {
        Console.WriteLine(inputNumber + " некратно одновременно 7 и 23");
    }
}


// version2(); //if-else

// void version2() //if-else
// {
//     Console.WriteLine("Введите число:");
//     string inputLine = Console.ReadLine() ?? "";

//     int inputNumber = int.Parse(inputLine);

//     if (inputNumber % 7 == 0 && inputNumber % 23 == 0)
//     {
//         Console.WriteLine(inputNumber + " одновременно кратно 7 и 23");
//     }
//     else
//     {
//         Console.WriteLine(inputNumber + " некратно одновременно 7 и 23");
//     }
// }