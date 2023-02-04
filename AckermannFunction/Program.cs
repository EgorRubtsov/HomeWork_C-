System.Console.WriteLine("Введите первое неотрицательное число: ");
int m = Convert.ToInt32(Console.ReadLine());


System.Console.WriteLine("Введите второе неотрицательное число: ");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(Recursion(m, n));


int Recursion(int firstNumber, int secondNumber)
{
    if(firstNumber == 0) return secondNumber + 1;
    else if (secondNumber == 0 && firstNumber > 0) return Recursion(firstNumber - 1, 1);
    return(Recursion(firstNumber - 1, Recursion(firstNumber, secondNumber - 1)));
}
