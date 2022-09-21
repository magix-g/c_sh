string n1;
int a;
int s=0;
Console.WriteLine("Введите число: ");
n1 = Console.ReadLine();

if(!double.TryParse(n1, out _))
 {Console.Write("Принимается только число!");
 return;}

a=Convert.ToInt32(n1); 
while(s<=a)
{
if(s%2==0)
   Console.WriteLine(s + " - четное; ");
s++;
}
   
