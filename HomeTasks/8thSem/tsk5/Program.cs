int size = 5; // c 5кой покрасивее
int tot = 1;
int i = 0;
int j = 0;

int[,] sqwerMat = new int[size, size];


while (tot <= size * size)
{
    sqwerMat[i, j] = tot;
    
    if (i <= j + 1 && i + j < sqwerMat.GetLength(1) - 1) j++;

    else if (i < j && i + j >= sqwerMat.GetLength(0) - 1) i++;

    else if (i >= j && i + j > sqwerMat.GetLength(1)-1) j--;

    else i--;
    tot++;
    
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


PrintArray2D(sqwerMat);
