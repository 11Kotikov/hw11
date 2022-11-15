// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] CreateNewArray (int x )
{
    int [] array = new int [x];
    for (int i =0; i<x; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void ShowArray (int [] array)
{
    System.Console.Write("Your array is [");
for (int i = 0; i<array.Length; i++)
{
    System.Console.Write(array[i]+ ", ");
}
System.Console.WriteLine("\b\b]");
}
System.Console.WriteLine($"Input integer and positive number that will be array length: ");
int x = Convert.ToInt32(Console.ReadLine());

ShowArray(CreateNewArray(x));
