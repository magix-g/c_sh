Console.WriteLine("ПЕРВАЯ ТОЧКА: ");
Console.Write("Введите первую координату: ");
string a1 = Console.ReadLine();

Console.Write("Введите вторую координату: ");
string b1 = Console.ReadLine();

Console.Write("Введите третью координату: ");
string c1 = Console.ReadLine();

if(!int.TryParse(a1, out _) || !int.TryParse(b1, out _) || !int.TryParse(c1, out _))
{
      Console.Write("Принимается только целое число! Одна из координат неверна!");
      return;
}

Console.WriteLine("ВТОРАЯ ТОЧКА: ");
Console.Write("Введите первую координату: ");
string a2 = Console.ReadLine();

Console.Write("Введите вторую координату: ");
string b2 = Console.ReadLine();

Console.Write("Введите третью координату: ");
string c2 = Console.ReadLine();

if(!int.TryParse(a2, out _) || !int.TryParse(b2, out _) || !int.TryParse(c2, out _))
{
      Console.Write("Принимается только целое число! Одна из координат неверна!");
      return;
}

int aa1 = Convert.ToInt32(a1);
int bb1 = Convert.ToInt32(b1);
int cc1 = Convert.ToInt32(c1);
int aa2 = Convert.ToInt32(a2);
int bb2 = Convert.ToInt32(b2);
int cc2 = Convert.ToInt32(c2);

Console.WriteLine("Расстояние между точками = " + Math.Sqrt(Math.Pow(aa2-aa1,2) + Math.Pow(bb2-bb1,2) + Math.Pow(cc2-cc1,2) ));






