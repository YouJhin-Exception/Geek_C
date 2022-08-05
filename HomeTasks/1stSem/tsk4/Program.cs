Console.WriteLine("Введите число для определения диапазона N - ");
int n1 = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n1; i++){
    if (i % 2 == 0){
        Console.Write(i + " ");
    }     
}
