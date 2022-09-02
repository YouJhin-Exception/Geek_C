int[,,] CreateArray3D(int page, int row, int col)  //int min, int max)
{
    int[,,] array = new int[page, row, col];

    int[] numbs = new int[array.Length];


    int first = 10;
    for (int i = 0; i < numbs.Length; i++)
    {
        numbs[i] = first++;
    }
    for (int i = 0; i < numbs.Length; i++)
    {
        int rndPos = new Random().Next(0, numbs.Length);
        int temp = numbs[i];
        numbs[i] = numbs[rndPos];
        numbs[rndPos] = temp;
    }

    int index = 0;


    for (int i = 0; i < page; i++)
    {
        for (int j = 0; j < row; j++)
        {
            for (int k = 0; k < col; k++)
            {
                array[i, j, k] = numbs[index++];
                //new Random().Next(min, max + 1);
            }
        }
    }
    return array;
}

void PrintArray3D(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine($"Лист - {(i + 1)}");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]}-индекс эллемента-[{i}.{j}.{k}]\t");
                //System.Console.Write($"{Math.Round((array[i, j]), 2)}\t");
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine("--------------------------------");
    }

}

PrintArray3D(CreateArray3D(3, 4, 4));
