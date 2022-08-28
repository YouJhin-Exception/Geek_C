
double[,] CreateArray2D(int row, int col)
{
    double[,] array = new double[row, col];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().NextDouble() * 10;
        }
    }
    return array;
}

void PrintArray2D(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            //System.Console.Write($"{array[i, j]}\t");
            System.Console.Write($"{Math.Round((array[i, j]), 2)}\t");
        }
        System.Console.WriteLine();
    }

}

PrintArray2D(CreateArray2D(3, 4));

// int[,] CreateArray2D(int row, int col, int min, int max)
// {
//     int[,] array = new int[row, col];

//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return array;
// }