int SumIn (int a)
{           
    int result = 0;    
    
    string len = a.ToString();
    for (int i = 0; i < len.Length; i++)
    { 
        result += a%10;
        a/=10;      
    }
    return result;  

    
    
    //  while(a>0)
    // {
    //   result += a%10;
    //   a/=10;   
    // }
    // return result;

}
System.Console.Write($"Введите число -> ");
int a1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Сумма цифр в числе {a1} = "+ SumIn(a1));