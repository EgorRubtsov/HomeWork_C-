// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.



int[] Massiv (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random(). Next(99, 1000);
    }

    System.Console.WriteLine($"[{String.Join(", ", array)}]");

    return array;
}


int[] array = Massiv(17);

int count = 0;

for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0) count++;
}

System.Console.WriteLine("количество чётных чисел в массиве: " + (count));


