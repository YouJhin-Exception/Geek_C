Console.Write("Введите число - ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1<1 || n1>7)
    Console.WriteLine("Странная у вас неделя...");
else if (n1 == 6 || n1 == 7)  
    Console.WriteLine("Это выходной день");
else
    Console.WriteLine("Это рабочий день");