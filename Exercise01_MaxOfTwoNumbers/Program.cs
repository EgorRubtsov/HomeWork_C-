Console.Write("Enter first number: ");
double firstNumber = double.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
double secondNumber = double.Parse(Console.ReadLine()!);

double max;
double min;


if (firstNumber > secondNumber) 
{
    max = firstNumber;
    min = secondNumber;
}

else
{
    max = secondNumber;
    min = firstNumber;
}

Console.Write("Your Maximum Number: ");
Console.WriteLine(max);
Console.WriteLine("and");
Console.Write("Your Minimum Number: ");
Console.WriteLine(min);


