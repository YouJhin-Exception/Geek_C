// 57 - дополнительная

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

void PrintArray(int[] array)
{
    foreach (var item in array)
    {
        System.Console.Write(item + " ");
    }
}

void MinSort(int[] mass)
{
    for (int i = 0; i < mass.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < mass.Length; j++)
        {
            if (mass[j] < mass[minPos])                     // от большего >
            {
                minPos = j;
            }
        }
        int temp = mass[i];
        mass[i] = mass[minPos];
        mass[minPos] = temp;

    }
}

int[] InLine(int[,] array)
{
    int[] lineArray = new int[array.Length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            lineArray[i * array.GetLength(1) + j] = array[i, j];
        }
    }
    return lineArray;
}
void PrintNumbs(int[] array)
{
    int count = 1;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == array[i - 1]) count++;
        else
        {
            System.Console.WriteLine($"Число {array[i-1]} содержится в массиве {count} раз(а)");
            count = 1;
        }
        if (i == array.Length-1) System.Console.WriteLine($"Число {array[i]} содержится в массиве {count} раз(a)");
    }
}

int[,] array2D = CreateArray2D(5, 5, 0, 10);
PrintArray2D(array2D);
int[] lineArray = InLine(array2D);
System.Console.WriteLine();
PrintArray(lineArray);
System.Console.WriteLine();
MinSort(lineArray);
PrintArray(lineArray);
System.Console.WriteLine();
PrintNumbs(lineArray);