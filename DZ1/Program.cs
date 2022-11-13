// Просим пользователя ввести число


Console.Write("Введите 1е число: ");

string userInputNumber1 = Console.ReadLine() ?? "";


Console.Write("Введите 2е число: ");

string userInputNumber2 = Console.ReadLine() ?? "";

// Преобразовать строку в число 

int number1 = int.Parse(userInputNumber1);

int number2 = int.Parse(userInputNumber2);

// Сравниваем два числа
// Выводим результат

if (number1 > number2)
{
    Console.Write($"Результат: {number1} > {number2}");
}

if (number1 < number2)
{
    Console.Write($"Результат: {number1} < {number2}");
}

if (number1 == number2)
{
    Console.Write($"Результат: {number1} = {number2}");
}

