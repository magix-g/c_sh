// See https://aka.ms/new-console-template for more information
string n1, n2;
Console.WriteLine("Введите два числа: ");
Console.Write("Первое: ");
n1= Console.ReadLine();

Console.Write("Второе: ");
n2= Console.ReadLine();

if(!int.TryParse(n1, out int result))
 {Console.Write("Принимаются к сравнению только числа!");
 return;}

if(!int.TryParse(n2, out int result1))
 {Console.Write("Принимаются к сравнению только числа!");
 return;}

if(Convert.ToInt32(n1)>Convert.ToInt32(n2))
 Console.Write(n1 + " больше, чем " + n2 );  


if(Convert.ToInt32(n2)>Convert.ToInt32(n1))
 Console.Write(n1 + " меньше, чем " + n2 ); 
 
if(Convert.ToInt32(n2)==Convert.ToInt32(n1))
 Console.Write( "Числа равны!" ); 

