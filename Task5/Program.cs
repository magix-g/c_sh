string n1;

Console.Write("Введите трехзначное число: ");
n1=Console.ReadLine();

if(!double.TryParse(n1, out _))
 {Console.Write("Принимается только число!");
 return;}

if(n1.Length!=3)
 {Console.Write("Принимается только трехзначное число!");
 return;}

Console.Write("Вторая цифра веденного числа: ");
Console.Write(n1[1]);
