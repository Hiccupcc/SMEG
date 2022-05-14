int Ans; 
var (x, y, z) = GenRandomNumber();  
var (signI, signS) = GetRandomSign(); 
for (int i = 0; i < 5; i++)
{
   if (signS == "+")
   { 
        int randnum; 
        Random rnd = new Random();
        randnum = rnd.Next(1,100);
        Ans = x + y + z + randnum; 
        Console.WriteLine(Ans);    
   }
   else if (signS == "-")
    {
        int randnum; 
        Random rnd = new Random();
        randnum = rnd.Next(1, 100);
        Ans = x + y + z + randnum; 
        Console.WriteLine(Ans);    
    }
}
Console.ReadKey(); 
static (int, string) GetRandomSign()
{
   string signS = "";
   Random rnd = new Random(); 
   int signI = rnd.Next(1,3); 
   if (signI == 1)
   {
     signS = "+";
   }
   else if (signI == 2)
    {
     signS = "-";
    }

  return (signI, signS);
}
static (int, int, int) GenRandomNumber()
{
   int x; int y; int z; 
   Random rnd = new Random(); 
   x = rnd.Next(1, 3); 
   y  = rnd.Next(1, 3); 
   z = rnd.Next(1, 3); 
  return (x, y, z);
}