double[] CreateArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble()*99; 
        array[i] = Math.Round(array[i],2);
    }
    return array;
}

void PrintArray(double[] array)
{
    foreach (var item in array)
    {

        System.Console.Write(item + " ");

    }

}

void DifferenceMaxMin (double[] array)
{   
   PrintArray(array); 
   double max = array[1];
   double min = array[0];
   foreach (var item in array)
   {
    if(item>max) max=item;
    else if(item<min) min=item;    
   }
   System.Console.WriteLine();
   Console.WriteLine($"Максимальное значение = {max}, минимальное значение = {min}");
   Console.WriteLine($"Разница между максимальным и минимальным значением = {Math.Round((max - min),2)}");
   
}
DifferenceMaxMin(CreateArray(10));