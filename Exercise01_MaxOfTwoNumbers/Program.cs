Console.Write("Enter first number: ");
double firstNumber = double.Parse(Console.ReadLine()!);
Console.Write("Enter second number: ");
double secondNumber = double.Parse(Console.ReadLine()!);

double max;

if (firstNumber > secondNumber) 
{
    max = firstNumber;
}

else
{
    max = secondNumber;
}

Console.Write("Your Maximum Number: ");
Console.WriteLine(max);


