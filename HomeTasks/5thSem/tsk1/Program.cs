int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    foreach (var item in array)
    {

        System.Console.Write(item + " ");

    }

}


void CompareEven (int[] array)
{
    int count = 0;
    PrintArray(array);
    foreach (var item in array)
    {
        if(item%2==0)
        {
            count ++;
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Количество четных чисел в массиве-> "+count);
    
}


CompareEven(CreateArray(10,100,998));