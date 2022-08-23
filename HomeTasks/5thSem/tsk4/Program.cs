// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

void ProIzi(int[] array)
{
    PrintArray(array);    
    int[] proArr;
    if ( array.Length % 2 == 0 )
    proArr = new int[array.Length/2];
    else proArr = new int[array.Length/2+1]; 
   
    for (int i = 0; i < proArr.Length; i++)
    {
        proArr[i] = array[i] * array[array.Length-1-i];
    }
    if (array.Length % 2 != 0) // если длинна исходного не четная
    proArr[array.Length/2] = array[array.Length/2]; //замена последнего корня элемента, на нечетный, без парный в исходном масиве


    System.Console.WriteLine();
    PrintArray(proArr);

}

ProIzi(CreateArray(7,0,9));