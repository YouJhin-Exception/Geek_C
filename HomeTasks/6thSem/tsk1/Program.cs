System.Console.Write("Сколько цифр вы хотете проверить -> ");
int numb = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numb];

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Введите {i + 1}е число -> ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void CheckNumbs(int[] array)
{
    int count = 0;
    foreach (var item in array) if (item > 0) count++;
    System.Console.WriteLine($"Среди ваших чисел, положительных = " + count);
}
CheckNumbs(FillArray(array));