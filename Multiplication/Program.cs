// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве



int[] Massiv (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random(). Next(13);
    }

    System.Console.WriteLine($"[{String.Join(", ", array)}]");
    System.Console.WriteLine();

    return array;
}


int[] array = Massiv(13);
System.Console.Write("[");

int  multiplication;
int j = array.Length;


for(int i = 0; i < array.Length/2; i++)

    { 
        multiplication = array[i] * array[j - 1];
        j--;
        System.Console.Write($"{String.Join(", ", multiplication + ", ")}");
    }

if(array.Length % 2 > 0)
{
int A = array[array.Length / 2 ];
System.Console.Write(A);
System.Console.WriteLine("]");
}
else
{
    System.Console.Write("]");
    System.Console.WriteLine();
}




