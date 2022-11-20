Console.WriteLine("Программа, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.");

Console.Write("Введите число для поиска: ");
int input = int.Parse(Console.ReadLine()!);

Console.Write("Введите число строк таблицы: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите число столбцов таблицы: ");
int n = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(m, n);
PrintArray(array);

if (IsExist(array)) Console.WriteLine("Искомого элемента нет в массиве.");
else SearchElement(array);


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

bool IsExist(int[,] array)
{
    bool isExist = true;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == input)
                return false;
        }

    }
    return isExist;
}

void SearchElement(int[,] array)
{
    Console.WriteLine("Искомый элемент имеет индексы: ");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == input) Console.WriteLine($"[{i}, {j}]");
        }

    }

}