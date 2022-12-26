System.Console.Write("Please, enter any positive number: ");
double number = Convert.ToDouble(Console.ReadLine());

double result = 1;
int index = 1;

while (index <= number)
{
    result = Math.Pow(result, 3);
    System.Console.WriteLine($"Третьей степенью числа " + (index) + " является число " + (result));
    index++;
    result = index;
}