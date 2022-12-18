Console.Write("Введите любое число: ");
double number = double.Parse(Console.ReadLine()!);

if (number%2 == 0)

    Console.WriteLine($"Введенное вами число <{number}> является четным");


else 

    Console.WriteLine($"Введенное вами число <{number}> является нечетным");

