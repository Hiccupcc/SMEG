int TaskFinish = 0;
while (TaskFinish == 0)
{ 
int Ans = 0; 
int Value = 100;
var (x, y, z) = GenRandomNumber();  
var (signI, signS) = GenRandomSign(); 
 for (int i = 0; i < 2; i++)
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
  
  if (Ans == Value)
  {
    TaskFinish++;
    Console.ForegroundColor = ConsoleColor.Red; 
    Console.WriteLine("The number 100 appeared.");
    Console.ReadKey(); 
    break;
    
  }

}
 
static (int, string) GenRandomSign()
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