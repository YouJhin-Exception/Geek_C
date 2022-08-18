int StepN (int a, int b)
{
    int result = 1;
    for (int i = 0; i < b; i++)
    {
      result*=a;
    }
    return result;
}

System.Console.Write($"Введите число -> ");
int a1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Введите степень для числа {a1} -> ");
int b1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write($"{a1} в степени {b1} = "+StepN(a1,b1));

//System.Console.WriteLine(Math.Pow(5,5));
