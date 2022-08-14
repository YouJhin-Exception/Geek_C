Console.Write("Введите 5-значное число ->");
int n = Convert.ToInt32(Console.ReadLine());
int nt = n;
int nRev = 0;

void palCheck (int n1)
{
  if (nt>9999 && nt<100000 )
  {
   while(n !=0)
      {
         int tail = n % 10;
         nRev = nRev*10 + tail;   // работает для любого n, - реверс числа, Math.reverse
         n = n/10;
      }
      if (nt==nRev)
      Console.Write("число -> "+nt+" полиндром");
      else
      Console.Write("число -> "+nt+" не является полиндром");
   
  }else
  Console.WriteLine("Это не 5-значное число!");   
}
palCheck(n);  

//через строку

// string nString = Console.ReadLine();
// if (nString[0]==nString[4] && nString[1]==nString[3])
// {
//    палиндром
// }else не палиндром