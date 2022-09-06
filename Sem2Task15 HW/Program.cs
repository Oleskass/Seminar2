//===========================================================
// #15 Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот 
// день выходным. Например: 6 -> да, 7 -> да, 1 -> нет
//===========================================================

ReadData();
CalculateData();
PrintData();

//объявляем глобальные переменные
int inputNumber;
bool result;

//получаем число от пользователя
void ReadData()
{
    Console.WriteLine("Введите цифру дня недели: ");
    string inputLine = Console.ReadLine() ?? "";
    inputNumber = int.Parse(inputLine);
}

//определяем какой день недели считать выходным
void CalculateData()
{
    result = (inputNumber == 6 || inputNumber == 7);
}

//выводим данные вычисления
void PrintData()
{
    if (result)
    {
        Console.WriteLine("Это выходной");
    }
    else if (inputNumber >= 1 && inputNumber <= 5)
    {
        Console.WriteLine("Это будний день");
    }
    else
    {
        Console.WriteLine("Это не день недели");
    }
}


// //Через Dictionary
// Dictionary<int, string> dict = new Dictionary<int, string>
// {
//     [1] = "Это будний день",
//     [2] = "Это будний день",
//     [3] = "Это будний день",
//     [4] = "Это будний день",
//     [5] = "Это будний день",
//     [6] = "Это выходной день",
//     [7] = "Это выходной день",
// };

// Console.WriteLine("Введите цифру дня недели: ");
// string inputLine = Console.ReadLine() ?? "";
// int inputNumber = int.Parse(inputLine);

// Console.WriteLine(dict[inputNumber]);