// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.









int [,] Array = GetArray(11, 7, 0, 6);

PrintArray(Array);
System.Console.WriteLine();

double [] arr = Average(Array);
System.Console.WriteLine(arr);





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



double [] Average(int[,] array)
{
    double [] massiv = new double[array.GetLength(1)];
    double sum = 0;
    int j = 0;
    int k = 0;

    while(j < array.GetLength(1))
    {
        for(int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }   
    massiv[k] = Math.Round(sum / array.GetLength(0), 4);
    System.Console.Write($"Среднее арифметическое столбца под номером {j + 1} составляет: {massiv[k]}");
    System.Console.WriteLine();
    sum = 0;
    j++;
    k++;
    }
    return massiv;
}