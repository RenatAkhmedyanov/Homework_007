Console.WriteLine("Программа, которая сортирует элементы массива по возрастанию слева направо и сверху вниз.");

Console.Write("Введите число строк таблицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов таблицы: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(m, n);
Console.WriteLine("Полученный массив:");
PrintArray(array);
SortArray(array);
Console.WriteLine("Отсортированный массив:");
PrintArray(array);

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 41);
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

int[,] SortArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[a, b] < array[i, j])
                    {
                        int temp = array[a, b];
                        array[a, b] = array[i, j];
                        array[i, j] = temp;
                    }
                }


            }
        }
    }

    return array;
}