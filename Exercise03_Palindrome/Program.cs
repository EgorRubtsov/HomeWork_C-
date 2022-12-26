System.Console.Write("Введите любое пятизначное число: ");
int palindrome = Convert.ToInt32(Console.ReadLine());
while (palindrome < 10000 || palindrome > 99999)
{
    System.Console.WriteLine("Введенное вами число не является пятизначным, введите число из дипазона: 10 000  до  99 999: ");
     palindrome = Convert.ToInt32(Console.ReadLine());
}

int num1 = palindrome % 10;
int num2 = palindrome / 10 % 10;
int num3 = palindrome / 100 % 10;
int num4 = palindrome / 1000 % 10;
int num5 = palindrome / 10000 % 10;

int result = ((((num1*10+num2)*10+num3)*10+num4)*10+num5);

if (result == palindrome)
{
    System.Console.WriteLine($"Введенное вами число {palindrome} является палиндромом");
}
else
{
    System.Console.WriteLine($"Введенное вами число {palindrome} НЕ является палиндромом");
}



