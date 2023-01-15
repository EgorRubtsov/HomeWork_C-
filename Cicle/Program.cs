// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, 
// будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл



int degreeOfnumber(int firstNumber, int secondNumber)
{
   

    int result = firstNumber;

    for(int i = 2; i <= secondNumber; i++)
    {
         result = result * firstNumber;
    }
    System.Console.WriteLine($"Результатом возведения числа: {firstNumber} в степень: {secondNumber} является: {result}");
    
    return result;
    
}


degreeOfnumber(new Random().Next(2, 7), new Random().Next(2, 7));

