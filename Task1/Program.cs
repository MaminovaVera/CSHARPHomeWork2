//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}
void ShowSecondDigit(int userNum)
{
    if (userNum >= 100 && userNum < 1000)
    {
        int result = userNum / 10 % 10;
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("Число не 3-х значное");
    }
}


int value = Prompt("Введите 3-х значное число > ");
ShowSecondDigit(value);
