Console.WriteLine("Введите первое число - ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число - ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число - ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = Math.Max(n1, (Math.Max(n2,n3)));
Console.WriteLine("Максимальное число из этих трех чисел это "+max);

