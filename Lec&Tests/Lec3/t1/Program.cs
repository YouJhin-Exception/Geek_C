void PrintArray (int[] array)
{
    int count = array.Length; 
    for (int i = 0; i < count; i++)
    {
       Console.Write(array[i]+" "); 
    }
}




void MinSort(int[] mass )
{
    for (int i = 0; i < mass.Length - 1; i++)
    {
        int minPos = i;
        for (int j = i+1 ; j < mass.Length; j++)
        {
            if (mass[j]<mass[minPos])                     // от большего >
            {
                minPos = j;
            } 
        }
        int temp = mass[i];
        mass[i] = mass[minPos];
        mass[minPos] = temp;

    }
}
int[] array = {2,4,7,8,5,3,1,0,9,0};
PrintArray(array);
MinSort(array);
Console.WriteLine();
PrintArray(array);