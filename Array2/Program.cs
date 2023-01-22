// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах.



int[] Massiv (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random(). Next(51);
    }

    System.Console.WriteLine($"[{String.Join(", ", array)}]");
    System.Console.WriteLine();

    return array;
}


int[] array = Massiv(12);

System.Console.Write("Сумма элементов ");

int sum = 0;

for(int i = 0; i < array.Length; i++)
{
    if(i % 2 > 0) sum += array[i];
}

for(int i = 1; i < array.Length; i+=2)
{
    Console.Write($"{String.Join(", ", array[i] + ", ")}");
}


System.Console.WriteLine("равна: "+sum);


