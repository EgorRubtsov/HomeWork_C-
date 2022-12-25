System.Console.Write("Введите любое трехзначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 999 || number < 100)
{
    System.Console.WriteLine("Ваше число не является трехзначным, введите число от 100 до 999");
}
else
{
    System.Console.WriteLine($"Вторая цифра вашего числа: " + (number/10)%10);
}
