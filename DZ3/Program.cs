// Просим пользователя ввести число


Console.Write("Введите число: ");

string userInput = Console.ReadLine() ?? "";


// Преобразовать строку в число 

int number = int.Parse(userInput);

// Делим число на 2 и проверяем на остаток
// Выводим результат

if (number % 2 == 0)
{
    Console.Write($"Результат: {number} - чётное число");
}
else
{
    Console.WriteLine($"Результат: {number} - не является четным");
}