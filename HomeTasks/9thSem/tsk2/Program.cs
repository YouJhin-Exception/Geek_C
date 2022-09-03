System.Console.Write($"Введите M -> ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Введите N -> ");
int n = Convert.ToInt32(Console.ReadLine());

int NaturalSum (int m, int n)
{
    if(n==m) return n;     
    return n + NaturalSum(m,n-1);
    
}

System.Console.WriteLine(NaturalSum(m,n));