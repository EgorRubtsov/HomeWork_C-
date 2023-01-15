// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.









System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма всех отдельных элементов числа {number} равна: {sumOfElements(number)}");



 int sumOfElements(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number%10;
        number = number/10;
    }

  return sum;
}




