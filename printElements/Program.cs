// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.






System.Console.WriteLine("Введите первое число числового ряда: ");
int A = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("Введите последнее число числового ряда: ");
int B = Convert.ToInt32(Console.ReadLine());

int count = B - A + 1;

System.Console.WriteLine($"Сумма числового ряда равна: " + Recursion(A, count));

int Recursion(int firstNumber, int count)
{
    if(count == 0) return 0;
    return (firstNumber  + Recursion(firstNumber + 1, count - 1));
}


