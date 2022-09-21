// See https://aka.ms/new-console-template for more information
string n1, n2, n3;
int max;

Console.WriteLine("Введите три числа: ");
Console.Write("Первое: ");
n1 = Console.ReadLine();

Console.Write("Второе: ");
n2 = Console.ReadLine();

Console.Write("Третье: ");
n3 = Console.ReadLine();

if(!int.TryParse(n1, out int result))
 {Console.Write("Принимаются к сравнению только числа!");
 return;}

if(!int.TryParse(n2, out int result1))
 {Console.Write("Принимаются к сравнению только числа!");
 return;}

if(!int.TryParse(n3, out int result2))
 {Console.Write("Принимаются к сравнению только числа!");
 return;}

max=Convert.ToInt32(n1);  

if(Convert.ToInt32(n2)>max)
  max=Convert.ToInt32(n2); 
 
if(Convert.ToInt32(n3)>max)
  max=Convert.ToInt32(n3);  

Console.Write("Максимальное из трех чисел: " + max);