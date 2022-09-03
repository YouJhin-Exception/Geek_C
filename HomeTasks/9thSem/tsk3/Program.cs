System.Console.Write($"Введите M -> ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Введите N -> ");
int n = Convert.ToInt32(Console.ReadLine());

int Akkerman (int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return Akkerman(m - 1, 1);
    else return Akkerman(m - 1, Akkerman(m, n - 1));
    
}

System.Console.WriteLine(Akkerman(m,n));
