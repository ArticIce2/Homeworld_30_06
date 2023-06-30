// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// Random random = new Random();

// int size = 10;

// int[] array = new int[size];
// for(int i = 0; i < size; i++)
// {
// array[i] = random.Next(100,1000);
// }

// int count = 0;
// for(int i = 0; i < size; i++)
// {
// if(array[i]%2 == 0)
// {
// count ++;
// }
// }
// System.Console.WriteLine("Количество чётных чисел" +  count);



// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// Random random = new Random();

// int size = 10;

// int[] array = new int[size];
// for(int i = 0; i < size; i++)
// {
// array[i] = random.Next(1,100);
// }

// int sum = 0;
// for(int i = 0; i < size; i++)
// {
// sum +=array[i];
// }

// Console.WriteLine("Сумма элементов на нечетных позициях: " + sum);





// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// double[] array = { 3.22, 4.2, 1.15, 77.15, 65.2 };

// double max = array[0];
// double min = array[0];

// for(int i = 0; i < array.Length;i++)
// {
// if(array[i] > max)
// max = array[i];
// else if(array[i] < min)
// min = array[i];
// }
// double answer = (max - min);

// Console.WriteLine("Разница между максимальным и минимальным элементами: " + answer);