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


int[,] ResultArray(int[,] arrA, int[,] arrB)
{
    int[,] resArr = new int[arrA.GetLength(0), arrB.GetLongLength(1)];

    for (int i = 0; i < resArr.GetLength(0); i++)
    {
        for (int j = 0; j < resArr.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < resArr.GetLength(1); k++)
            {
                sum += arrA[i, k] * arrB[k, j];
            }
            resArr[i, j] = sum;
        }
    }
    return resArr;
}

int[,] testA = new int[,] { { 2, 4 }, { 3, 2 } };
int[,] testB = new int[,] { { 3, 4 }, { 3, 3 } };

PrintArray2D(ResultArray(testA,testB));
