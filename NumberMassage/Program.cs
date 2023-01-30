// Напишите программу, которая на вход принимает число, и проверяет есть ли такое число в двумерном массиве, 
// а также возвращает сообщение о том, что оно найдено или же указание, что такого элемента нет.





Console.Write("Введите количество строк: "); 
int rows = Convert.ToInt32(Console.ReadLine()!); 
 
Console.Write("Введите количество столбцов: "); 
int columns = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Введите искомое число: "); 
int number = Convert.ToInt32(Console.ReadLine()); 

 
int[,] array = GetArray(rows, columns, 0, 8); 
PrintArray(array); 

if(FindNumber(array)) 
{Console.WriteLine($"Число {number} есть в массиве");}
else
{Console.WriteLine($"Число {number} отсутствует в массиве");}



int[,] GetArray(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

bool FindNumber(int[,] array)
{

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] == number)
            
            return true;
        }
   
    }
    return false;
}

