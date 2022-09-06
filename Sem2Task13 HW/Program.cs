//===========================================================
// #13 Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// Например: 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6
//===========================================================

//через  char
ReadData();
CalculateData();
PrintData();

//объявляем глобальные переменные
int inputNumber, arrayLength; //введённый номер и длина нашего числа(массива в будущем)
char[] charArray; //массив

//получаем число от пользователя
void ReadData()
{
    Console.WriteLine("Введите число: "); //оно должно быть не больше 2147483647 по модулю (max и min для int)
    string inputLine = Console.ReadLine() ?? "";
    inputNumber = int.Parse(inputLine);
}

//вычисления
void CalculateData()
{
    charArray = inputNumber.ToString().ToCharArray(); //преобразуем введённое число в массив символов
    arrayLength = charArray.Length; //вычисляем длину массива
    //Console.WriteLine(arrayLength); //можно вывести в терминал длину массива
}

//вывод результата
void PrintData()
{
    if (inputNumber >= 0) //для положительных чисел
    {
        if (arrayLength >= 3)
        {
            Console.WriteLine("Третья цифра введённого вами числа: " + charArray[2]);
        }
        else
        {
            Console.WriteLine("Третьей цифры у вашего числа нет, оно ещё маленькое :(");
        }
    }
    else //для отрицательных чисел
    {
        if (arrayLength >= 4)
        {
            Console.WriteLine("Третья цифра введённого вами числа: " + charArray[3]);
        }
        else
        {
            Console.WriteLine("Третьей цифры у вашего числа нет, оно ещё маленькое :(");
        }
    }
}
