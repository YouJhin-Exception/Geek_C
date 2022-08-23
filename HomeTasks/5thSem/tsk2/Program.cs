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

void NegSum (int[] array)
{
    int sum = 0;
    PrintArray(array);
    for (int i = 1; i < array.Length; i+=2)
    {
        sum+=array[i];
    }
    System.Console.WriteLine();
    System.Console.WriteLine("Сумма элементов на нечетных позициях = "+sum);
}

NegSum(CreateArray(10,0,9));
