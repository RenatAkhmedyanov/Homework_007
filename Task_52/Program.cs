Console.WriteLine("Программа, которая считает среднее арифметическое элементов в каждом столбце.");

Console.Write("Введите число строк таблицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов таблицы: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(m, n);
PrintArray(array);
GetAverageOfColumn(array);

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,4}", array[i, j]));
        }
        Console.WriteLine();
    }
}

void GetAverageOfColumn(int[,] arary)
{

    for (int i = 0; i < array.GetLength(1); i++)
    {
        int sum = 0;
        double average = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
            average = (double)sum / m;
        }
        Console.WriteLine($"Среднее арифметическое элементов {i+1} столбца: " + Math.Round(average, 2));
    }


}