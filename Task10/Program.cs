Console.Write("Введите целое число: ");
string x = Console.ReadLine();

if(!int.TryParse(x, out _))
{
      Console.Write("Принимается только целое число!");
      return;
}

int a = Convert.ToInt32(x);
int i = 1;

while(i<=a)
    {Console.WriteLine("Куб от " + i + " = " + i*i*i);
    i++;}