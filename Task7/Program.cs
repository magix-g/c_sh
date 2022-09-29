Console.Write("Введите целое число от 1 до 7: ");
string x = Console.ReadLine();
if(!int.TryParse(x, out _))
{
      Console.Write("Принимается только целое число от 1 до 7!");
      return;
}

int y=Convert.ToInt32(x);

if(y<1 || y>7)
{
    Console.Write("Принимается только целое число от 1 до 7");
    return;
}

if(y>=6)
  Console.Write("Введенный день - выходной!");
else 
  Console.Write("Введенный день - будний!");
