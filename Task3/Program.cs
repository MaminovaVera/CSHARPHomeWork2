// Напишите программу, которая выводит третью цифру заданного 
// числа или сообщает, что третьей цифры нет.

int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считавает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int Show3digit(int value)
{
    while (value > 1000)
    {
        value = value / 10;
    }
    int result = value % 10;
    return result;
}
int value = Prompt("Введите число ");
if (value > 99)
{
    int result = Show3digit(value);
    System.Console.WriteLine(result);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
