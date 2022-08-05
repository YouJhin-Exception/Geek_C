// через тернарник проще всего

Console.WriteLine("Введите число для проверки на четность - ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n1 % 2 == 0 ? "Четное" : "Не четное");