Console.Write("Введите любое положительное целое число: ");
int number = int.Parse(Console.ReadLine()!);

int number1 = 1;

Console.Write($"Четными в ряду чисел от <1> до <{number}> являются числа: ( ");

while (number1 <= number)
{
if (number1 % 2 == 0)
    
    Console.Write($"{number1}, ");
    
    number1++;
}
Console.WriteLine(")");