System.Console.Write("Введите значение переменной b1 -> ");
double b1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите значение переменной k1 -> ");
double k1 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите значение переменной b2 -> ");
double b2 = Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите значение переменной k2 -> ");
double k2 = Convert.ToDouble(Console.ReadLine());

void CrossPoint(double b1, double k1, double b2, double k2)
{
    double x1 = (b2 - b1) / (k1 - k2);
    double x2 = x1 * k1 + b1;
    System.Console.WriteLine("Точка пересечения имеет координаты -> "+Math.Round(x1, 2) + " : " + Math.Round(x2, 2));
    
}
CrossPoint(b1, k1, b2, k2);

// можно еще добавить проверку по типу 
// if (b1 == b2) && (k1 == k2) - совпадают
//    if (b1 != b2) && (k1 == k2) - параллельны