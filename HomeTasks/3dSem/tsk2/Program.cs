Console.Write("Введите координаты 1й точки (через Enter) -> ");
double []spot1 = new double[3];
spot1[0] =  Convert.ToDouble(Console.ReadLine());
spot1[1] =  Convert.ToDouble(Console.ReadLine());
spot1[2] =  Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координаты 2й точки (через Enter) -> ");
double []spot2 = new double[3];
spot2[0] =  Convert.ToDouble(Console.ReadLine());
spot2[1] =  Convert.ToDouble(Console.ReadLine());
spot2[2] =  Convert.ToDouble(Console.ReadLine());

double Dist3D (double[] sp1, double[] sp2)
{
  double dis = Math.Sqrt(Math.Pow(spot2[0]-spot1[0],2) + Math.Pow(spot2[1]-spot1[1],2) + Math.Pow(spot2[2]-spot1[2],2));
  Console.WriteLine("Растояние между точками -> "+Math.Round(dis,2));
  return dis;
}  

Dist3D(spot1,spot2);
