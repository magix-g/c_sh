Console.Write("Введите целое пятизначное число: ");
string x = Console.ReadLine();

if(!int.TryParse(x, out _))
{
      Console.Write("Принимается только целое пятизначное число!");
      return;
}

if(x.Length!=5)
{
      Console.Write("Принимается только целое пятизначное число!");
      return;
}

int count = x.Length;
int j=0;
//string xx = new string(x.Reverse().ToArray());

char[] xx = new char[5];

while(j < x.Length)
    {
        xx[j] = x[count-1];
        j++;
        count--;
    }

string s = new string(xx);
int a=Convert.ToInt32(s);
int b=Convert.ToInt32(x);

if(a==b)
   Console.Write("Палиндром!");
else 
   Console.Write("Не палиндром!");