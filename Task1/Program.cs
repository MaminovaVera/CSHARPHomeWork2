//Напишите программу, которая принимает на вход трёхзначное число и на выходе 
//показывает последнюю цифру этого числа.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int userNum = Prompt("Введите 3-х значное число > ");

int result = userNum /10 % 10;
Console.WriteLine(result);
