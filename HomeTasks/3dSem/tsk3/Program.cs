void Cube (int n)
{
    Console.Write(n+" -> ");
    int i = 1;
    while (i<=n)
    {
        System.Console.Write(Math.Pow(i,3)+" ");
        i++;
    }
    System.Console.WriteLine();
    //System.Console.WriteLine(Math.Pow(n,3)+".");

}
Cube(3);
Cube(5);
Cube(7);