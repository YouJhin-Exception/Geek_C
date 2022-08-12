Console.Write("Введите число - ");
int n1 = Convert.ToInt32(Console.ReadLine());
string n1str = Convert.ToString(n1);

if(n1str.Length>2)
{
   Console.WriteLine("третья цифра "+n1str[2]); 
}
else
Console.WriteLine("третьей цифры нет");



// без стринга 

// Console.Write("Введите число - ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// while(n1>1000)
//  n1 = n1/10;
// Console.WriteLine(n1%10);