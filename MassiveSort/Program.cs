// Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


Console.Write("Введите количество строк: "); 
int rows = Convert.ToInt32(Console.ReadLine()!); 
 
Console.Write("Введите количество столбцов: "); 
int columns = Convert.ToInt32(Console.ReadLine()); 



int[,] array = GetArray(rows, columns, 0, 44); 
PrintArray(array); 
System.Console.WriteLine();
Method(array);
PrintArray(array);



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


void Method(int [,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
     {
        
        
            for(int j = 0; j < array.GetLength(1) ; j++)
            {
                for(int k = 0; k < array.GetLength(1) - 1 ; k++)   

                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;

                }
            }
        
     }
}
