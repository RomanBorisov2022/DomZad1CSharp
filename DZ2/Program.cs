// Просим пользователя ввести число
Console.Write("Введите 1е число: ");

string userInputNumber1 = Console.ReadLine() ?? "";

Console.Write("Введите 2е число: ");

string userInputNumber2 = Console.ReadLine() ?? "";

Console.Write("Введите 3е число: ");

string userInputNumber3 = Console.ReadLine() ?? "";

// Преобразовать строку в число 
int number1 = int.Parse(userInputNumber1);

int number2 = int.Parse(userInputNumber2);

int number3 = int.Parse(userInputNumber3);

// Сравниваем два числа
// Выводим результат

if (number1 > number2 & number1 > number3)
{
    Console.Write($"Результат: max = {number1}");
}
if (number2 > number1 & number2 > number3)
{
    Console.Write($"Результат: max = {number2}");
}
if (number3 > number1 & number3 > number2)
{
    Console.Write($"Результат: max = {number3}");
}





