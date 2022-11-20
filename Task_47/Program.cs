Console.WriteLine("Программа, выводит двумерный массив размерностью m*n, заполненный вещественными числами");

Console.Write("Введите число строк таблицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов таблицы: ");
int n = int.Parse(Console.ReadLine()!);

double[,] array = GetArray(m, n);
PrintArray(array);


double[,] GetArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-100, 100) / 10.0;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,6}", array[i, j]));
        }
        Console.WriteLine();
    }
}






