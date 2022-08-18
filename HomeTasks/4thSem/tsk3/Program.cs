int [] mass1 = new int[8];


int [] ConsoleArray (int[] carr )
{

    for (int i = 0; i < carr.Length; i++)
    {
    System.Console.Write($"Введите {i} эллемент массива -> "); 
    carr[i] = Convert.ToInt32(Console.ReadLine()); 
    }
    return carr;

}

int [] RandomArr (int[] rarr)
{
    for (int i = 0; i < rarr.Length; i++)
    {
        rarr[i] = new Random().Next(0,99); // для красоты (в задании 2х значные)
    }
    return rarr;

}

void PrintArr (int [] arr)  //
{
    foreach (var item in arr)
    {
        
        System.Console.Write(item+" ");
        
    }

}

//RandomArr(mass1);
//PrintArr(mass1);

ConsoleArray(mass1);
PrintArr(mass1);