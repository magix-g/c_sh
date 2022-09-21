string n1;
double ost;

Console.WriteLine("Введите число: ");
n1 = Console.ReadLine();

if(!double.TryParse(n1, out _))
 {Console.Write("Принимается только число!");
 return;}

ost=Convert.ToDouble(n1); 

if(ost%2>0)
   Console.Write(n1 + " нечетное");
else
   Console.Write(n1 + " четное");