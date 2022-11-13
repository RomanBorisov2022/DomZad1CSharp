Console.WriteLine("Дано первое число: 1");
int userInput = 1;
Console.Write("Введите второе число, больше единицы: ");
int secondNumber = int.Parse(Console.ReadLine());
int n = userInput + 1;
while (secondNumber-1 > n)
{
    Console.Write($"{n}, ");
    n = n + 2;
}
Console.Write(n);
  
    