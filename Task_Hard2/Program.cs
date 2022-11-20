// Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , 
// причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. 
// Перемешать случайным образом элементы массива, причем чтобы каждый ГАРАНТИРОВАННО переместился на другое место и 
// выполнить это за m*n / 2 итераций. И после этого чтоб каждый уже перемещенный элемент не трогали.
// То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.

Console.WriteLine("Программа, которая выводит перемешивает элементы массива, с четным количеством элементов");

Console.Write("Введите число строк таблицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов таблицы: ");
int n = int.Parse(Console.ReadLine()!);

if (m % 2 == 0 || n % 2 == 0)
{
    int[,] array = GetArray(m, n);
    Console.WriteLine();
    Console.WriteLine("Исходный массив");
    PrintArray(array);

    int[] oneDimensionArray = GetOneDimensionArray(array);

    Console.WriteLine();


    Random rand = new Random();
    for (int i = oneDimensionArray.Length - 1; i >= 1; i--)
    {

        int j = rand.Next(i + 1);
        int count = 0;
        while (i == j)
        {
            j = rand.Next(i + 1);
            count++;
        }

        if (count > m * n / 2)
        {
            Console.WriteLine("При перемешивании массива, было превышено количество итераций(половина произведения строк и столбцов массива). Элементы массива не будут переставлены. Перезапустите программу.");
        }

        else
        {
            int tmp = oneDimensionArray[j];
            oneDimensionArray[j] = oneDimensionArray[i];
            oneDimensionArray[i] = tmp;
        }
    
    }

    Console.WriteLine();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = oneDimensionArray[i * n + j];
        }
    }
    Console.WriteLine("Полученный массив.");
    PrintArray(array);




}
else Console.WriteLine("Одно из введеных чисел должно быть четным!");


int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random((int)DateTime.Now.Ticks);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 60);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}", array[i, j]));
        }
        Console.WriteLine();
    }
}

int[] GetOneDimensionArray(int[,] array)
{
    int[] oneDimensionArray = new int[m * n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            oneDimensionArray[i * n + j] = array[i, j];
        }
    }
    return oneDimensionArray;
}