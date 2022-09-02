int[,] CreateArray2D(int row, int col, int min, int max)
{
    int[,] array = new int[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
            //System.Console.Write($"{Math.Round((array[i, j]), 2)}\t");
        }
        System.Console.WriteLine();
    }

}

void SumEll(int[,] arr)
{
    int lineCount = 0;
    int minSum = Int32.MaxValue;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++) sum += arr[i, j];

        if (sum < minSum)
        {
            lineCount = i;
            minSum = sum;
        }
        System.Console.WriteLine($"Сумма {i + 1}й строки = " + sum);
    }
    System.Console.WriteLine($"Минимальная сумма эллементов на {lineCount + 1}й строке и равна = " + minSum);
}

int[,] arr = CreateArray2D(4, 4, 0, 20);
PrintArray2D(arr);
SumEll(arr);