System.Console.Write($"Введите M -> ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write($"Введите N -> ");
int n = Convert.ToInt32(Console.ReadLine());

int NaturalNumbs (int m, int n)
{
    if(n==m) return n; 
    System.Console.Write(m+" ");
    return NaturalNumbs(m+1,n);
    
}
System.Console.WriteLine(NaturalNumbs(m,n));
