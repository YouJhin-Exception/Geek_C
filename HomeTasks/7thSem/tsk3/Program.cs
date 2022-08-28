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
        }
        System.Console.WriteLine();

    }

}

void ArmMean (int[,] arr)
{  
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double mean = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            mean += arr[i,j];
        }
        System.Console.WriteLine($"Реднее арифмитическое {i+1}-го столбца = "+ Math.Round((mean/arr.GetLength(1)),2));
    }
}

int[,] array = CreateArray2D(3,4,1,9);
PrintArray2D(array);

ArmMean(array);
