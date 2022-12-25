System.Console.Write("Введите любое число, не превышающее 100 000: ");
 int number = int.Parse(Console.ReadLine()!);

if (number > 99 && number < 1000)
{
System.Console.WriteLine($"Третья цифра введенного числа: " + (number%10));
}
else if (number >= 1000 && number < 10000)
{
    System.Console.WriteLine($"Третья цифра введенного числа: " + ((number/10)%10));
}
else if (number >= 10000 && number < 100000)
{
    System.Console.WriteLine($"Третья цифра введенного числа: " + ((number/100)%10));
}
else if (number == 100000)
{
    System.Console.WriteLine($"Третья цифра введенного числа: " + ((number/1000)%10));
}

else 
{
    System.Console.WriteLine("Данное число не имеет третьей цифры, либо является отрицательным, либо больше 100 000");
}