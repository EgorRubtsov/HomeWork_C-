// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве



int[] Massiv (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random(). Next(9);
    }

    System.Console.WriteLine($"[{String.Join(", ", array)}]");
    System.Console.WriteLine();

    return array;
}


int[] array = Massiv(11);
{
int lentharray = array.Length / 2;
if (array.Length % 2 > 0) lentharray++;
int[]  multiplication = new int[lentharray];
int j = array.Length;


for(int i = 0; i < array.Length/2; i++)

    { 
        multiplication[i] = array[i] * array[j - 1];
        j--;
    }
if(array.Length % 2 > 0)

    multiplication[array.Length/2] = array[array.Length / 2];

   
System.Console.Write($"[{String.Join(", ", multiplication)}]");

System.Console.WriteLine();
}










