



// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.Write("Введите количество строк: "); 
int rows = Convert.ToInt32(Console.ReadLine()!); 
 
Console.Write("Введите количество столбцов: "); 
int columns = Convert.ToInt32(Console.ReadLine()); 



int[,] array = GetArray(rows, columns, 0, 8); 
PrintArray(array); 
System.Console.WriteLine();
int[,] array2 = GetArray(rows, columns, 0, 8); 
PrintArray(array2); 
System.Console.WriteLine();
int[,] Matrix = newMatrix(array, array2);
PrintArray(Matrix);



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



int [,] newMatrix(int [,] array1, int [,] array2)
{
    int [,] matrix = new int[array1.GetLength(0), array1.GetLength(1)];
    {
        for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
            {
                for(int k = 0; k < array.GetLength(0); k++)
                {
                    matrix[i, j] += array1[i,k]*array2[k,j]; 
                }
            }
        }
    }
    return matrix;
}


