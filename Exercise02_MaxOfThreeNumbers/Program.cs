Console.Write("Enter first number: ");
double number1 = double.Parse(Console.ReadLine());
Console.Write("Enter second number: ");
double number2 = double.Parse(Console.ReadLine());
Console.Write("Enter third number: ");
double number3 = double.Parse(Console.ReadLine());

double max = number1;

if (number2 > max)
{
    max = number2;
}

else 
{
    max = number1;
}

if (number3 > max)
{
    max = number3;
}

else
{
    max = max;
}

Console.Write("Max number = ");
Console.WriteLine(max);
