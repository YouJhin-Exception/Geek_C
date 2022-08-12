Console.Write("Введите трехзначное число - ");
int n1 = Convert.ToInt32(Console.ReadLine());
if ((n1 / 100 > 0) && (n1 / 1000 == 0))
 {
  int n2 = (n1/10)%10;
  Console.WriteLine(n2);
 }
else
Console.WriteLine("Число НЕ трехзначное");










