//Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
int Prompt(string message)
{
    System.Console.Write(message);          // Вывести сообщение
    string readValue = Console.ReadLine();  // Считывает с консоли строку
    int result = int.Parse(readValue);      // Преобрадует строку в целое число
    return result;                          // Возвращает результат
}

int DayOfWeek = Prompt($"Введите номер дня недели  > ");

if (DayOfWeek < 1 || DayOfWeek > 7)
{
    Console.WriteLine("Это не день недели ");
    return;
}
if (DayOfWeek == 6 || DayOfWeek == 7)
{
    Console.WriteLine("Да");

}
else
{
    Console.WriteLine("Нет");
}






