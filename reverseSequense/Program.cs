// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.





System.Console.WriteLine("Введите первое число вашего числового ряда: ");
int N = Convert.ToInt32(Console.ReadLine());

string reverseSequence = new string(Recursion(N, 1));


System.Console.WriteLine(reverseSequence);


string Recursion(int firstNumber, int lastNumber)
{
    if (firstNumber == lastNumber) return firstNumber.ToString();
    return (firstNumber + ", " + Recursion(firstNumber - 1, lastNumber));
}


