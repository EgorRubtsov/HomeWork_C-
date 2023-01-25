
// Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).





int[] array = Massiv(17);

Sequence(array);

int[] Massiv (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random(). Next(101);
    }

    System.Console.WriteLine($"[{String.Join(", ", array)}]");

    return array;
}





void Sequence(int[] array)
{

for (int i = 0; i < array.Length; i++) 
{
    for (int j = 0; j < array.Length-1; j++)
    {

        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
}

Console.WriteLine($"[{String.Join(", ", array)}]");
}



