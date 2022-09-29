string x;
Console.Write("Введите число: ");
x = Console.ReadLine();

if(!double.TryParse(x, out _))
 {Console.Write("Принимается только число!");
 return;}

if (x.Length < 3)
Console.Write("Третьего числа нет!");
else
Console.Write("Третья цифра заданного числа: " + x[2]); 


