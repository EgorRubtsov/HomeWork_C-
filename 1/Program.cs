// / Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

// Для строки можно использовать данный метод string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
// (пользователь вводит в консоли числа через пробел и они формируют строку)




System.Console.WriteLine("Введите числа: ");



 int[] numS = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);



int count = 0;

for(int i = 0; i < numS.Length; i++)
{
    if(numS[i] > 0) count++;

}
  

System.Console.WriteLine($"Вы ввели {count} положительных чисел");