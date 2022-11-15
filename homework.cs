
// Здраствуйте, тут придётся немного подождать:)

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] CreateNewArray (int x )
// {
//     int [] array = new int [x];
//     for (int i =0; i<x; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray (int [] array)
// {
//     System.Console.Write("Your array is [");
// for (int i = 0; i<array.Length; i++)
// {
//     System.Console.Write(array[i]+ ", ");
// }
// System.Console.WriteLine("\b\b]");
// }

// void CountEvenNumbers (int [] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i]%2==0)
//         {
//             count++;
//         }
//     }
//     System.Console.WriteLine("Ugh, it's difficult, I'll count it now...");
//     Thread.Sleep(2000);
//         System.Console.WriteLine("omg..idk");
//         Thread.Sleep(1000);
//             System.Console.WriteLine("it's hard to belive i'm machine...[-_-]");
//             Thread.Sleep(2000);
//                 System.Console.WriteLine("...The quantity of even numbers in your array is "+count+", and don't make me do it again [>_<]");

// }
// CountEvenNumbers (newArray);

// System.Console.WriteLine($"Input integer and positive number that will be array length: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int [] newArray = CreateNewArray(x);
// ShowArray(newArray);

// Задача 36: Задайте массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] CreateNewArray (int x )
// {
//     int [] array = new int [x];
//     for (int i =0; i<x; i++)
//     {
//         array[i] = new Random().Next(-15, 11);
//     }
//     return array;
// }

// void ShowArray (int [] array)
// {
//     System.Console.Write("Your array is [");
// for (int i = 0; i<array.Length; i++)
// {
//     System.Console.Write(array[i]+ ", ");
// }
// System.Console.WriteLine("\b\b]");
// }

// int FindOddSum (int [] array)
// {
//     int sum = 0;
//     for (int i=1; i<array.Length; i=i+2)
//     {
//         sum+= array[i];
//     }
//     return sum;
// }

// System.Console.WriteLine($"Input integer and positive number that will be array length: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int [] newArray = CreateNewArray(x);
// ShowArray(newArray);
// System.Console.Write($"Sum of the elements in odd positions is {FindOddSum(newArray)}");
