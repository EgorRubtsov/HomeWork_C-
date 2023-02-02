

// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// Console.Write("Введите количество строк: "); 
// int rows = Convert.ToInt32(Console.ReadLine()!); 
 
// Console.Write("Введите количество столбцов: "); 
// int columns = Convert.ToInt32(Console.ReadLine()); 



// int[,] array = GetArray(rows, columns, 0, 8); 
// PrintArray(array); 
// System.Console.WriteLine();
// int minString =  sumOfRows(array);
// System.Console.WriteLine($" Строка с номером {minString} содержит в себе минимальную сумму элементов");


// int[,] GetArray(int m, int n, int minValue, int maxValue){
//     int[,] result = new int[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }



// int sumOfRows(int [,] array)
// {
//     int minTemp = 100000;
//     int nunerOfMinString = 0;
    
//     for(int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
        

//         for(int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
        
//         if(sum < minTemp)
//         {
//             minTemp = sum;
//             nunerOfMinString = i + 1;
//         } 
//     }

//    return nunerOfMinString;
// }





Console.Write("Введите количество строк: "); 
int rows = Convert.ToInt32(Console.ReadLine()!); 
 
Console.Write("Введите количество столбцов: "); 
int columns = Convert.ToInt32(Console.ReadLine()); 



int[,] array = GetArray(rows, columns, 0, 8); 
PrintArray(array); 
System.Console.WriteLine();
int minString =  sumOfRows(array);
System.Console.WriteLine($" Строка с номером {minString} содержит в себе минимальную сумму элементов");


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



int sumOfRows(int [,] array)
{
    int minTemp = 0;
    int numberOfMinString = 0;


    for(int i = 0; i < 1; i++)
    {
       
        for(int j = 0; j < array.GetLength(1); j++)
        {
            minTemp += array[i, j];
            numberOfMinString = i + 1;
        }
    }


    
    for(int i = 1; i < array.GetLength(0); i++)
    {
        int sum = 0;
        

        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        
        if(sum < minTemp)
        {
            minTemp = sum;
            numberOfMinString = i + 1;
        } 
    }

   return numberOfMinString;
}
