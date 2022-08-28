
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

System.Console.Write($"Введите номер строки -> ");
int i = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Введите номер столбца -> ");
int j = Convert.ToInt32(Console.ReadLine());

int FindEll(int[,] array, int i, int j)
{
    if ((i < 0 || i >= array.GetLength(0)) || (j < 0 || j >= array.GetLength(1)))
    {
        System.Console.WriteLine("Неправильная позиция - Такого элемета нет");
        return -1;
    }
    else System.Console.WriteLine($" На заданных позициях {i} и {j} находится цифра-> {array[i,j]}");
    return array[i, j];

}

int[,] arr = CreateArray2D(3, 4, 1, 100);
PrintArray2D(arr);
FindEll(arr,i,j);

// System.Console.WriteLine(arr[i,j]); - а можно было просто так ))