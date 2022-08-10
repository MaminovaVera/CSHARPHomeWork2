// Напишите программу, которая выводит третью цифру заданного 
//числа или сообщает, что третьей цифры нет.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int userNum = Prompt("Введите число > ");
int third = userNum % 10;
Console.WriteLine(userNum);
if (userNum >= 100 && userNum < 1000)
{
    Console.WriteLine(third);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
